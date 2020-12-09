﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace CarRentalWF
{
    public partial class RentInfoForm : Form
    {
        readonly CarRentalManagement _carRentalManagement = CarRentalManagement.GetInstance();
        private Rent _rent;
        private bool _isReturn;
        public int MileageForm { get; private set; }
        public DateTime ReturnDateForm { get; private set; }
        public bool FormSaved { get; private set; }

        public RentInfoForm()
        {
            _rent = null;
            InitializeComponent();
            _isReturn = false;
        }

        public RentInfoForm(Rent rent, bool isReturn = false)
        {
            InitializeComponent();
            _rent = rent;

            txtCustomer.Text = _rent.CustomerName;
            txtVehicle.Text = _rent.VehicleId;
            dtStartDate.Value = _rent.StartDate;
            dtEndDate.Value = _rent.EndDate;
            txtMileage.Text = _rent.Mileage.ToString();
            if (_rent.ReturnDate != null)
            {
                dtReturnDate.Value = (DateTime)_rent.ReturnDate;
            }
            _isReturn = isReturn;
            if (isReturn)
            {
                txtCustomer.Enabled = false;
                txtVehicle.Enabled = false;
                dtStartDate.Enabled = false;
                dtEndDate.Enabled = false;
                txtPeriod.Enabled = false;
                cbCustomEndDate.Enabled = false;
                cbStatus.Enabled = false;
                FormSaved = false;
            }
        }
        private void RentInfoForm_Load(object sender, EventArgs e)
        {
            foreach (string status in Enum.GetNames(typeof(RentStatus)))
            {
                cbStatus.Items.Add(status);
            }
            if (_rent == null)
            {
                cbStatus.SelectedIndex = 0;
            }
            else
            {
                cbStatus.SelectedIndex = (int)Enum.Parse(typeof(RentStatus), _rent.Status.ToString());
            }
            cbCustomEndDate.Checked = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = _rentInfoHandle();
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
                return;
            }
            string vehicleId = txtVehicle.Text;
            Vehicle vehicle = _carRentalManagement.GetVehicle(vehicleId);
            if (vehicle == null)
            {
                MessageBox.Show("Can't find vehicle", "Error");
            }
            else if (vehicle.Available == false && (_rent == null || (_rent != null && _rent.VehicleId != vehicleId)))
            {
                MessageBox.Show("The vehicle is unavailable for rent", "Error");
            }
            //else if ((_isReturn || cbStatus.SelectedIndex == (int)RentStatus.Finish) && )
            else
            {
                if ((_isReturn || cbStatus.SelectedIndex == (int)RentStatus.Finish) && int.Parse(txtMileage.Text) < vehicle.CurrentMileage)
                {
                    DialogResult isAccept = MessageBox.Show("The mileage is smaller than the current mileage(" + vehicle.CurrentMileage + "). Are you sure to continue?", "Warning", MessageBoxButtons.YesNo);
                    if (isAccept != DialogResult.Yes)
                    {
                        return;
                    }
                }
                if (_isReturn)
                {
                    MileageForm = int.Parse(txtMileage.Text);
                    ReturnDateForm = dtReturnDate.Value;
                    FormSaved = true;
                    Close();
                    return;
                }
                string customerName = txtCustomer.Text;
                DateTime startDate;
                DateTime endDate;
                RentStatus status = (RentStatus)Enum.Parse(typeof(RentStatus), cbStatus.Text);
                startDate = dtStartDate.Value;
                int? mileage;
                DateTime? returnDate;
                if (cbStatus.SelectedIndex == (int)RentStatus.Finish || _isReturn)
                {
                    mileage = int.Parse(txtMileage.Text);
                    returnDate = dtReturnDate.Value;
                }
                else
                {
                    mileage = null;
                    returnDate = null;
                }
                if (_rent == null)
                {
                    if (cbCustomEndDate.Checked)
                    {
                        endDate = dtEndDate.Value;
                        _carRentalManagement.AddRental(customerName, vehicle, startDate, endDate, returnDate, mileage, status);
                    }
                    else
                    {
                        _carRentalManagement.AddRental(customerName, vehicle, startDate, double.Parse(txtPeriod.Text), returnDate, mileage, status);
                    }
                }
                else
                {
                    if (cbCustomEndDate.Checked)
                    {
                        endDate = dtEndDate.Value;
                        _carRentalManagement.UpdateRental(customerName, _rent.Id, vehicle, startDate, endDate, returnDate, mileage, status);
                    }
                    else
                    {
                        _carRentalManagement.UpdateRental(customerName, _rent.Id, vehicle, startDate, double.Parse(txtPeriod.Text), returnDate, mileage, status);
                    }
                }
                FormSaved = true;
                Close();
            }
        }

        private void cbCustomEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if (_isReturn)
            {
                return;
            }
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
        private string _rentInfoHandle()
        {
            double testDou;
            int testI;
            int status = _isReturn ? cbStatus.SelectedIndex + 1 : cbStatus.SelectedIndex;
            if (txtCustomer.Text == "")
            {
                return "You must complete customer name field!";
            }
            else if (txtVehicle.Text == "")
            {
                return "You must complete vehicle id field!";
            }
            else if (cbCustomEndDate.Checked && dtEndDate.Value <= dtStartDate.Value)
            {
                return "Your end date must be happenned after start date!";
            }
            else if (!cbCustomEndDate.Checked && !double.TryParse(txtPeriod.Text, out testDou))
            {
                return "Your period must be a number!";
            }
            else if (!cbCustomEndDate.Checked && double.Parse(txtPeriod.Text) <= 0)
            {
                return "Your period must be greater than zero!";
            }
            else if (status == (int)RentStatus.Finish)
            {
                if (dtReturnDate.Value <= dtStartDate.Value)
                {
                    return "Your return date must be happenned after start date!";
                }
                else if (!int.TryParse(txtMileage.Text, out testI))
                {
                    return "Your mileage must be a number!";
                }
                else if (int.Parse(txtMileage.Text) < 0)
                {
                    return "Your mileage must be greater than or equal zero!";
                }
            }
            return "";
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status = _isReturn? cbStatus.SelectedIndex + 1 : cbStatus.SelectedIndex;
            if (status != (int)RentStatus.Finish)
            {
                txtMileage.Enabled = false;
                dtReturnDate.Enabled = false;
            }
            else
            {
                txtMileage.Enabled = true;
                dtReturnDate.Enabled = true;
            }
        }
    }
}
