﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace CarRentalWF
{
    public partial class RentUserForm : Form
    {
        readonly CarRentalManagement _carRentalManagement = CarRentalManagement.GetInstance();
        private Rent _rent = null;
        public bool FormSaved { get; private set; }
        public RentUserForm(Vehicle vec)
        {
            InitializeComponent();
            lblID.Text = vec.Id.ToString();
            lblVehicleName.Text = vec.Name;
            lblBrand.Text = vec.Brand;
            lblColor.Text = vec.Color;
            lblYear.Text = vec.Year.ToString();
            lblSeat.Text = vec.NumberOfSeat.ToString();
            lblPrice.Text = vec.Price.ToString();
            lblCondition.Text = vec.ConditionText;
            cbCustomEndDate.Checked = true;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            string errorMessage = _rentUserHandle();
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
                return;
            }
            int vehicleId = int.Parse(lblID.Text);
            Vehicle vehicle = _carRentalManagement.GetVehicle(vehicleId);
            if (vehicle == null)
            {
                MessageBox.Show("Can't find vehicle", "Error");
            }
            else if (vehicle.Available == false)
            {
                MessageBox.Show("The vehicle is unavailable for rent", "Error");
            }
            else
            {
                int customerId = int.Parse(txtCustomer.Text);
                DateTime startDate = dtStartDate.Value;
                DateTime endDate;
                if (_rent == null)
                {
                    if (cbCustomEndDate.Checked)
                    {
                        endDate = dtEndDate.Value;
                        _carRentalManagement.AddRent(customerId, vehicle, startDate, endDate, null, null);
                    }
                    else
                    {
                        _carRentalManagement.AddRent(customerId, vehicle, startDate, double.Parse(txtPeriod.Text), null, null);
                    }
                }
                FormSaved = true;
                Close();
            }
        }
        private string _rentUserHandle()
        {
            double temp;
            if (txtCustomer.Text == "")
            {
                return "You must complete customer name field!";
            }
            else if (cbCustomEndDate.Checked && dtEndDate.Value <= dtStartDate.Value)
            {
                return "Your end date must be happenned after start date!";
            }
            else if (!cbCustomEndDate.Checked && !double.TryParse(txtPeriod.Text, out temp))
            {
                return "Your period must be a number!";
            }
            else if (!cbCustomEndDate.Checked && double.Parse(txtPeriod.Text) <= 0)
            {
                return "Your period must be greater than zero!";
            }
            return "";
        }

        private void cbCustomEndDate_CheckedChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtStartDate.Value;
            double period;
            if (cbCustomEndDate.Checked)
            {
                if (double.TryParse(txtPeriod.Text, out period))
                {
                    dtEndDate.Value = startDate.AddDays(period);
                }
                txtPeriod.Enabled = false;
                dtEndDate.Enabled = true;
            }
            else
            {
                txtPeriod.Text = ((int)((dtEndDate.Value - dtStartDate.Value).TotalDays + 0.5)).ToString();
                dtEndDate.Enabled = false;
                txtPeriod.Enabled = true;
            }
        }
    }
}
