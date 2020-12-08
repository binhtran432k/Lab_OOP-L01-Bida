using System;
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
        Rent _rent = null;

        public RentInfoForm()
        {
            InitializeComponent();

            cbStatus.Enabled = false;
        }

        public RentInfoForm(Rent rent)
        {
            InitializeComponent();
            _rent = rent;

            txtCustomer.Text = _rent.CustomerID.ToString();
            txtVehicle.Text = _rent.VehicleID.ToString();
            txtStartDate.Text = _rent.StartDate.ToString("dd/MM/yyyy");
            txtEndDate.Text = _rent.EndDate.ToString("dd/MM/yyyy");
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
                cbStatus.Text = _rent.Status.ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int vehicleID = int.Parse(txtVehicle.Text);
            Vehicle vehicle = _carRentalManagement.GetVehicle(vehicleID);
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
                CultureInfo culture = CultureInfo.InvariantCulture;
                DateTime startDate;
                DateTime endDate;
                int customerID = int.Parse(txtCustomer.Text);
                double price = vehicle.Price;
                RentStatus status = (RentStatus)Enum.Parse(typeof(RentStatus), cbStatus.Text);

                if (_rent == null)
                {   
                    if (txtStartDate.Text == "" && txtEndDate.Text == "")
                    {
                        _rent = new Rent(customerID, vehicleID, price);
                    }
                    else if (txtStartDate.Text == "")
                    {
                        endDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", culture);
                        _rent = new Rent(customerID, vehicleID, price, endDate);
                    }
                    else
                    {
                        startDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", culture);
                        endDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", culture);
                        _rent = new Rent(customerID, vehicleID, price, startDate, endDate);                  
                    }


                    _carRentalManagement.AddRent(_rent);
                    vehicle.UpdateAvailable(false);
                }
                else
                {
                    startDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", culture);
                    endDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", culture);
                    _rent.Update(customerID, vehicleID, price, startDate, endDate, status);
                }
                Close();
            }
        }
    }
}
