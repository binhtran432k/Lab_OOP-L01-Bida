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

            txtCustomer.Text = _rent.CustomerName;
            txtVehicle.Text = _rent.VehicleID;
            txtTotal.Text = _rent.Total.ToString();
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
            string vehicleID = txtVehicle.Text;
            Vehicle vehicle = _carRentalManagement.GetVehicle(vehicleID);
            if (vehicle == null)
            {
                MessageBox.Show("Can't find vehicle or vehicle is unavailable", "Error");
            }
            else
            {
                CultureInfo culture = CultureInfo.InvariantCulture;
                string customerName = txtCustomer.Text;
                double total = double.Parse(txtTotal.Text);
                DateTime startDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", culture);
                DateTime endDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", culture);
                RentStatus status = (RentStatus)Enum.Parse(typeof(RentStatus), cbStatus.Text);

                if (_rent == null)
                {
                    _rent = new Rent(customerName, vehicleID, total, startDate, endDate);
                    _carRentalManagement.AddRent(_rent);
                }
                else
                {
                    _rent.Update(customerName, vehicleID, total, startDate, endDate, status);
                }
                Close();
            }
        }
    }
}
