using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalWF
{
    public partial class RentalForm : Form
    {
        readonly CarRentalManagement _carRentalManagement = CarRentalManagement.GetInstance();
        readonly BindingSource _rentBindingSource = new BindingSource();
        public RentalForm()
        {
            InitializeComponent();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            _rentBindingSource.DataSource = _carRentalManagement.RentList;

            rentDataGridView.AutoGenerateColumns = false;
            rentDataGridView.DataSource = _rentBindingSource;

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Form rentForm = new RentInfoForm();

            rentForm.FormClosed += (s, a) =>
            {
                _rentBindingSource.ResetBindings(false);
            };

            rentForm.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int index = rentDataGridView.SelectedRows[0].Index;
            Rent rent = _carRentalManagement.RentList[index];
            Form rentForm = new RentInfoForm(rent);

            rentForm.FormClosed += (s, a) =>
            {
                _rentBindingSource.ResetBindings(false);
                UpdateBtnProcess();
            };

            rentForm.Show();
        }

        private void RentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBtnProcess();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            int index = rentDataGridView.SelectedRows[0].Index;
            Rent rent = _carRentalManagement.RentList[index];

            rent.UpdateStatus();
            _rentBindingSource.ResetBindings(false);
            UpdateBtnProcess();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = rentDataGridView.SelectedRows[0].Index;
            Rent rent = _carRentalManagement.RentList[index];
            _carRentalManagement.RemoveRent(rent);
            _rentBindingSource.ResetBindings(false);
            UpdateBtnProcess();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            int index = rentDataGridView.SelectedRows[0].Index;
            Rent rent = _carRentalManagement.RentList[index];
            rent.Cancel();
            _rentBindingSource.ResetBindings(false);
            UpdateBtnProcess();
        }

        private void UpdateBtnProcess()
        {
            string status = rentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            if (status == "Ready")
            {
                btnProcess.Show();
                btnCancel.Show();
                btnProcess.Text = "Pickup Vehicle";
            }
            else if (status == "Ongoing")
            {
                btnProcess.Show();

                btnCancel.Show();
                btnProcess.Text = "Return Vehicle";
            }
            else
            {
                btnProcess.Hide();
                btnCancel.Hide();
            }
        }
    }
}
