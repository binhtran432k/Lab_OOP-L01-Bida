﻿using System;
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
    public partial class VehicleInfoForm : Form
    {
        readonly CarRentalManagement _carRentalManagement = CarRentalManagement.GetInstance();
        Vehicle _vehicle = null;
        public VehicleInfoForm()
        {
            InitializeComponent();
        }

        public VehicleInfoForm(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;

            nameText.Text = vehicle.Name;
            colorText.Text = vehicle.Color;
            brandText.Text = vehicle.Brand;
            yearText.Text = vehicle.Year.ToString();
            seatText.Text = vehicle.NumberOfSeat.ToString();
            conditionText.Text = vehicle.Condition.ToString();
            priceText.Text = vehicle.Price.ToString();

            currentMileageText.Text = vehicle.CurrentMileage.ToString();
            engineServiceText.Text = vehicle.LastEngineServiceMileage.ToString();
            transmissionServiceText.Text = vehicle.LastTransmissionServiceMileage.ToString();
            tireServiceText.Text = vehicle.LastTireServiceMileage.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string type = typeComboBox.Text;
            string name = nameText.Text;
            string color = colorText.Text;
            string brand = brandText.Text;
            int year = int.Parse(yearText.Text);
            int numberOfSeat = int.Parse(seatText.Text);
            double price = double.Parse(priceText.Text);
            int condition = int.Parse(conditionText.Text);
            int currentMileage = int.Parse(currentMileageText.Text);
            int engineMileage = int.Parse(engineServiceText.Text);
            int transmissionMileage = int.Parse(transmissionServiceText.Text);
            int tireMileage = int.Parse(tireServiceText.Text);
            if (_vehicle == null)
            {
                if (type == "Car")
                {
                    Car car = new Car(name, color, brand, year, numberOfSeat, price, condition, currentMileage, engineMileage, transmissionMileage, tireMileage, true);
                    _carRentalManagement.AddVehicle(car);
                }
                else
                {
                    Truck truck = new Truck(name, color, year, price, condition, currentMileage, engineMileage, transmissionMileage, tireMileage, true);
                    _carRentalManagement.AddVehicle(truck);
                }
            }
            else
            {
                _vehicle.Update(name, color, brand, year, numberOfSeat, price, condition, currentMileage);
            }

            Close();
        }

        private void VehicleInfoForm_Load(object sender, EventArgs e)
        {
            typeComboBox.Items.Add("Car");
            typeComboBox.Items.Add("Truck");
            typeComboBox.SelectedIndex = 0;

            if (_vehicle != null)
            {
                typeComboBox.Text = _vehicle.Type;
                typeComboBox.Enabled = false;
                if (_vehicle.Type == "Truck")
                {
                    brandText.Enabled = false;
                    seatText.Enabled = false;
                }
            }
        }
    }
}
