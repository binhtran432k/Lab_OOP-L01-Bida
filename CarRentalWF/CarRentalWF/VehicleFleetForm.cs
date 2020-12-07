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
    public partial class VehicleFleetForm : Form
    {
        readonly CarRentalManagement _carRentalManagement = CarRentalManagement.GetInstance();
        readonly BindingSource _vehicleBindingSource = new BindingSource();

        public VehicleFleetForm()
        {
            InitializeComponent();
        }

        private void VehicleFleetForm_Load(object sender, EventArgs e)
        {
            _vehicleBindingSource.DataSource = _carRentalManagement.VehicleList;

            vehicleGridView.AutoGenerateColumns = false;
            vehicleGridView.DataSource = _vehicleBindingSource;

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Form vehicleForm = new VehicleInfoForm();
            vehicleForm.FormClosed += (s, a) =>
            {
                _vehicleBindingSource.ResetBindings(false);
            };

            vehicleForm.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int index = vehicleGridView.SelectedRows[0].Index;
            Vehicle vec = _carRentalManagement.VehicleList[index];
            MessageBox.Show(vec.ToString());

            Form vehicleForm = new VehicleInfoForm(vec);
            vehicleForm.FormClosed += (s, a) =>
            {
                _vehicleBindingSource.ResetBindings(false);
            };

            vehicleForm.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = vehicleGridView.SelectedRows[0].Index;
            Vehicle vec = _carRentalManagement.VehicleList[index];

            _carRentalManagement.RemoveVehicle(vec);
            _vehicleBindingSource.ResetBindings(false);
        }

        private void BtnServeFleet_Click(object sender, EventArgs e)
        {
            string serviceReport = _carRentalManagement.ServeFleet();
            MessageBox.Show(serviceReport, "Service Report");
        }

        private void ViewMaintenance_Click(object sender, EventArgs e)
        {
            int index = vehicleGridView.SelectedRows[0].Index;
            int id = int.Parse(vehicleGridView.Rows[index].Cells[0].Value.ToString());
            Form maintenaceForm = new MaintenanceForm(id);
            maintenaceForm.ShowDialog();
        }

        private void vehicleGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.vehicleGridView.Rows[e.RowIndex];
                //Process data to send
                int selectedId = int.Parse(row.Cells[0].Value.ToString());
                //Init
            }
        }
    }
}
