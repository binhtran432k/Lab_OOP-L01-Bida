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
    public partial class ServiceForm : Form
    {
        public string Kind { get; set; }
        public string Type { get; set; }
        public int VehicleID { get; set; }
        public DateTime ServeTime { get; set; }
        public int Mileage { get; set; }
        public double Cost { get; set; }
        public string Garage { get; set; }
        public MaintenanceJob Job { get; set; }

        readonly CarRentalManagement _carRentalManagement = CarRentalManagement.GetInstance();

        public ServiceForm()
        {
            InitializeComponent();
            Job = null;
        }

        public ServiceForm(string kind, string type, int vehicleID, DateTime serveTime, int mileage)
        {
            InitializeComponent();
            Job = null;
            Text = kind + " service";
            Kind = kind;
            Type = type;
            VehicleID = vehicleID;
            ServeTime = serveTime;
            Mileage = mileage;
            SetServiceText();
        }

        private void SetServiceText()
        {
            Vehicle vehicle = _carRentalManagement.GetVehicle(VehicleID);
            lblService.Text += string.Format("Apply {0} {1} service for vehicle #{2}\n", Type, Kind, VehicleID);
            lblService.Text += string.Format("Vehicle name: {0}\n", vehicle.Name);
            lblService.Text += string.Format("Mileage: {0}km\n", vehicle.CurrentMileage);
            lblService.Text += string.Format("Serve time: {0}", ServeTime);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            double cost = double.Parse(txtCost.Text);
            string garage = txtGarage.Text;
            Job = new MaintenanceJob(Kind, Type, VehicleID, ServeTime, Mileage, cost, garage, true);
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {   
            Close();
        }
    }
}
