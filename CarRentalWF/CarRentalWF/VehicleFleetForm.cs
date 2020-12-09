using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.IO;
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
            _vehicleBindingSource.DataSource = _carRentalManagement.GetVehicleList();

            vehicleGridView.AutoGenerateColumns = false;
            vehicleGridView.DataSource = _vehicleBindingSource;
            vehicleGridView.Columns[6].DefaultCellStyle.Format = "N2";
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Form vehicleForm = new VehicleInfoForm();
            vehicleForm.FormClosed += (s, a) =>
            {
                _vehicleBindingSource.DataSource = _carRentalManagement.GetVehicleList();
            };

            vehicleForm.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int index = int.Parse(vehicleGridView.SelectedRows[0].Cells[0].Value.ToString());
            Vehicle vec = _carRentalManagement.GetVehicle(index);

            Form vehicleForm = new VehicleInfoForm(vec);
            vehicleForm.FormClosed += (s, a) =>
            {
                _vehicleBindingSource.DataSource = _carRentalManagement.GetVehicleList();
            };

            vehicleForm.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(vehicleGridView.SelectedRows[0].Cells[0].Value.ToString());
            Vehicle vec = _carRentalManagement.GetVehicle(index);

            _carRentalManagement.RemoveVehicle(vec);
            _vehicleBindingSource.DataSource = _carRentalManagement.GetVehicleList();
        }

        private void BtnServeFleet_Click(object sender, EventArgs e)
        {
            string serviceReport = _carRentalManagement.ServeFleet();
            MessageBox.Show(serviceReport, "Service Report");
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (vehicleGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only 1 vehicle to continue", "Error");
                return;
            }
            int index = int.Parse(vehicleGridView.SelectedRows[0].Cells[0].Value.ToString());
            Vehicle vec = _carRentalManagement.GetVehicle(index);
            ServiceHistory serviceHistory = vec.GetServiceHistory();

            var data = JsonConvert.SerializeObject(serviceHistory, Formatting.Indented);

            string directory = @"../../json/";
            string path = directory + vec.ID + ".json";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(data);
            }
            MessageBox.Show( "File  saved at json/"+vec.ID+".json");
        }

        private void BtnServiceHistory_Click(object sender, EventArgs e)
        {
            if (vehicleGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only 1 vehicle to continue", "Error");
                return;
            }
            int index = int.Parse(vehicleGridView.SelectedRows[0].Cells[0].Value.ToString());
            Vehicle vec = _carRentalManagement.GetVehicle(index);
            ServiceHistory serviceHistory = vec.GetServiceHistory();

            var data = JsonConvert.SerializeObject(serviceHistory, Formatting.Indented);
            MessageBox.Show(data, "Service History");
        }

        private void ViewMaintenance_Click(object sender, EventArgs e)
        {
            int id1 = int.Parse(vehicleGridView.SelectedRows[0].Cells[0].Value.ToString());
            Vehicle vehicle1 = _carRentalManagement.GetVehicle(id1);
            Form maintenaceForm;

            if (vehicleGridView.SelectedRows.Count > 2)
            {
                MessageBox.Show("You can select at most 2 vehicles to view service history", "Error");
                return;
            }
            else if (vehicleGridView.SelectedRows.Count == 2)
            {
                int id2 = int.Parse(vehicleGridView.SelectedRows[1].Cells[0].Value.ToString());
                Vehicle vehicle2 = _carRentalManagement.GetVehicle(id2);
                maintenaceForm = new MaintenanceJobForm(vehicle2, vehicle1);
            }
            else
            {
                maintenaceForm = new MaintenanceJobForm(vehicle1);
            }
            maintenaceForm.ShowDialog();
        }
    }
}
