using System;
using System.Globalization;
using System.Windows.Forms;

namespace CarRentalWF
{
    public partial class RentUserForm : Form
    {
        readonly CarRentalManagement _carRentalManagement = CarRentalManagement.GetInstance();
        readonly CustomerManagement _customerManagement = CustomerManagement.GetInstance();
        private readonly Rent _rent = null;
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
            int customerId = int.Parse(txtCustomer.Text);
            Customer customer = _customerManagement.GetCustomer(customerId);
            if (customer == null)
            {
                MessageBox.Show("Can't find customer", "Error");
            }
            else if (vehicle == null)
            {
                MessageBox.Show("Can't find vehicle", "Error");
            }
            else if (vehicle.Available == false)
            {
                MessageBox.Show("The vehicle is unavailable for rent", "Error");
            }
            else
            {
                DateTime startDate = dtStartDate.Value;
                DateTime endDate;
                if (_rent == null)
                {
                    if (cbCustomEndDate.Checked)
                    {
                        endDate = dtEndDate.Value;
                        _carRentalManagement.RentVehicle(customerId, vehicle, startDate, endDate);
                    }
                    else
                    {
                        _carRentalManagement.RentVehicle(customerId, vehicle, startDate, startDate.AddDays(double.Parse(txtPeriod.Text)));
                    }
                }
                FormSaved = true;
                Close();
            }
        }
        private string _rentUserHandle()
        {
            double temp;
            int testI;
            if (!int.TryParse(txtCustomer.Text, out testI))
            {
                return "Customer ID mus be a number!";
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

        private void CbCustomEndDate_CheckedChanged(object sender, EventArgs e)
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
