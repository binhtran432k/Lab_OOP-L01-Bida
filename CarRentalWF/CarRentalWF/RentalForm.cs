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
            _rentBindingSource.DataSource = _carRentalManagement.GetRentList();

            rentDataGridView.AutoGenerateColumns = false;
            rentDataGridView.DataSource = _rentBindingSource;
            rentDataGridView.Columns[4].DefaultCellStyle.Format = "N2";
            UpdateBtnProcess();
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
            Rent rent = _carRentalManagement.GetRent(index);
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
            int index = (int)rentDataGridView.SelectedRows[0].Cells[0].Value;
            Rent rent = _carRentalManagement.GetRent(index);
            if (rent != null && rent.Status == RentStatus.Ongoing)
            {
                RentInfoForm rentForm = new RentInfoForm(rent, true);

                rentForm.FormClosed += (s, a) =>
                {
                    if (rentForm.FormSaved)
                    {
                        _carRentalManagement.UpdateRentalStatus(rent.Id, rentForm.MileageForm, rentForm.ReturnDateForm);
                    }
                    _rentBindingSource.DataSource = _carRentalManagement.GetRentList();
                    UpdateBtnProcess();
                };

                rentForm.Show();
            }
            else
            {
                _carRentalManagement.UpdateRentalStatus(rent.Id, null, null);
                _rentBindingSource.DataSource = _carRentalManagement.GetRentList();
                UpdateBtnProcess();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = (int)rentDataGridView.SelectedRows[0].Cells[0].Value;
            _carRentalManagement.RemoveRent(index);
            _rentBindingSource.DataSource = _carRentalManagement.GetRentList();
            UpdateBtnProcess();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            int index = (int)rentDataGridView.SelectedRows[0].Cells[0].Value;
            _carRentalManagement.CancelRent(index);
            _rentBindingSource.DataSource = _carRentalManagement.GetRentList();
            UpdateBtnProcess();
        }

        private void UpdateBtnProcess()
        {
            string status;
            if (rentDataGridView.Rows.Count == 0)
            {
                status = null;
                btnUpdate.Hide();
                btnDelete.Hide();
            }
            else
            {
                status = rentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                btnUpdate.Show();
                btnDelete.Show();
            }
            if (status == "Ready")
            {
                btnProcess.Show();
                btnCancel.Show();
                btnProcess.Text = "Pickup Vehicle";
            }
            else if (status == "Ongoing")
            {
                btnProcess.Show();
                btnCancel.Hide();
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
