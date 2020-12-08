﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int index = vehicleGridView.SelectedRows[0].Index;
            Vehicle car = _carRentalManagement.VehicleList[index];

            var data = JsonConvert.SerializeObject(car, Formatting.Indented);

            string directory = @"../../json/";
            string path = directory + car.ID + ".json";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(data);
            }
            MessageBox.Show( "File  saved at json/"+car.ID+".json");
        }

        private void BtnServiceHistory_Click(object sender, EventArgs e)
        {
            int index = vehicleGridView.SelectedRows[0].Index;
            Vehicle car = _carRentalManagement.VehicleList[index];

            var data=JsonConvert.SerializeObject(car,Formatting.Indented);
            MessageBox.Show(data, "Service Report");
        }

        private void ViewMaintenance_Click(object sender, EventArgs e)
        {
            int index = vehicleGridView.SelectedRows[0].Index;
            int id = int.Parse(vehicleGridView.Rows[index].Cells[0].Value.ToString());
            Form maintenaceForm = new MaintenanceForm(id);
            maintenaceForm.ShowDialog();
        }
    }
}
