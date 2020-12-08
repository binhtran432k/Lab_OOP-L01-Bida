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
        private bool _isReturn;
        public int MileageForm { get; private set; }
        public DateTime ReturnDateForm { get; private set; }
        public bool FormSaved { get; private set; }

        public RentInfoForm()
        {
            InitializeComponent();
            _isReturn = false;
        }

        public RentInfoForm(Rent rent, bool isReturn = false)
        {
            InitializeComponent();
            _rent = rent;

            txtCustomer.Text = _rent.CustomerName;
            txtVehicle.Text = _rent.VehicleID;
            txtStartDate.Text = _rent.StartDate.ToString("dd/MM/yyyy");
            txtEndDate.Text = _rent.EndDate.ToString("dd/MM/yyyy");
            txtMileage.Text = _rent.Mileage.ToString();
            if (_rent.ReturnDate != null)
            {
                txtReturnDate.Text = ((DateTime)_rent.ReturnDate).ToString("dd/MM/yyyy");
            }
            _isReturn = isReturn;
            if (isReturn)
            {
                txtCustomer.Enabled = false;
                txtVehicle.Enabled = false;
                txtStartDate.Enabled = false;
                txtEndDate.Enabled = false;
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
            string vehicleID = txtVehicle.Text;
            Vehicle vehicle = _carRentalManagement.GetVehicle(vehicleID);
            if (vehicle == null)
            {
                MessageBox.Show("Can't find vehicle", "Error");
            }
            else if (vehicle.Available == false && cbStatus.SelectedIndex != (int)RentStatus.Ongoing && _isReturn)
            {
                MessageBox.Show("The vehicle is unavailable for rent", "Error");
            }
            else
            {
                CultureInfo culture = CultureInfo.InvariantCulture;
                string customerName = txtCustomer.Text;
                DateTime startDate;
                DateTime endDate;
                RentStatus status = (RentStatus)Enum.Parse(typeof(RentStatus), cbStatus.Text);
                string errorMessage = infoManagement();
                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage);
                    return;
                }
                if (_isReturn)
                {
                    MileageForm = int.Parse(txtMileage.Text);
                    ReturnDateForm = DateTime.ParseExact(txtReturnDate.Text, "dd/MM/yyyy", culture);
                }
                startDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", culture);
                if (_rent == null)
                {
                    if (txtMileage.Text == "" || txtReturnDate.Text == "")
                    {
                        if (cbCustomEndDate.Checked)
                        {
                            endDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", culture);
                            _rent = new Rent(customerName, vehicle, startDate, endDate, status);
                        }
                        else
                        {
                            _rent = new Rent(customerName, vehicle, startDate, double.Parse(txtEndDate.Text), status);
                        }
                    }
                    else
                    {
                        int mileage = int.Parse(txtMileage.Text);
                        DateTime returnDate = DateTime.ParseExact(txtReturnDate.Text, "dd/MM/yyyy", culture);
                        if (cbCustomEndDate.Checked)
                        {
                            endDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", culture);
                            _rent = new Rent(customerName, vehicle, mileage, startDate, endDate, returnDate, status);
                        }
                        else
                        {
                            _rent = new Rent(customerName, vehicle, mileage, startDate, double.Parse(txtEndDate.Text), returnDate, status);
                        }
                    }
                    _carRentalManagement.AddRent(_rent);
                    //vehicle.Available = false;
                }
                else
                {
                    if (txtMileage.Text == "" || txtReturnDate.Text == "")
                    {
                        if (cbCustomEndDate.Checked)
                        {
                            endDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", culture);
                            _rent.Update(customerName, startDate, endDate, status);
                        }
                        else
                        {
                            _rent.Update(customerName, startDate, double.Parse(txtEndDate.Text), status);
                        }
                    }
                    else
                    {
                        int mileage = int.Parse(txtMileage.Text);
                        DateTime returnDate = DateTime.ParseExact(txtReturnDate.Text, "dd/MM/yyyy", culture);
                        if (cbCustomEndDate.Checked)
                        {
                            endDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", culture);
                            _rent.Update(customerName, mileage, startDate, endDate, returnDate, status);
                        }
                        else
                        {
                            _rent.Update(customerName, mileage, startDate, double.Parse(txtEndDate.Text), returnDate, status);
                        }
                    }
                }
                FormSaved = true;
                Close();
            }
        }

        private void cbCustomEndDate_CheckedChanged(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            DateTime startDate;
            DateTime endDate;
            if (!DateTime.TryParseExact(txtStartDate.Text, "dd/MM/yyyy", culture, DateTimeStyles.None, out startDate))
            {
                updateTxtEndDate();
                return;
            }
            if (!DateTime.TryParseExact(txtEndDate.Text, "dd/MM/yyyy", culture, DateTimeStyles.None, out endDate))
            {
                double period;
                if (double.TryParse(txtEndDate.Text, out period))
                {
                    endDate = startDate.AddDays(period);
                }
                else
                {
                    updateTxtEndDate();
                    txtEndDate.Text = string.Empty;
                    return;
                }
            }
            if (cbCustomEndDate.Checked)
            {
                lblEndDate.Text = "End Date";
                txtEndDate.Text = endDate.ToString("dd/MM/yyyy");
            }
            else
            {
                lblEndDate.Text = "Period (Day)";
                txtEndDate.Text = (endDate - startDate).TotalDays.ToString();
            }
        }
        private void updateTxtEndDate()
        {
            if (cbCustomEndDate.Checked)
            {
                lblEndDate.Text = "End Date";
            }
            else
            {
                lblEndDate.Text = "Period (Day)";
            }
        }
        private string infoManagement()
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            DateTime testDate;
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
            else if (txtStartDate.Text == "")
            {
                return "You must complete start date field!";
            }
            else if (txtEndDate.Text == "")
            {
                return "You must complete end date field!";
            }
            else if (!DateTime.TryParseExact(txtStartDate.Text, "dd/MM/yyyy", culture, DateTimeStyles.None, out testDate))
            {
                return "Your start date does not match the date format dd/mm/yyyy!";
            }
            else if (cbCustomEndDate.Checked && !DateTime.TryParseExact(txtEndDate.Text, "dd/MM/yyyy", culture, DateTimeStyles.None, out testDate))
            {
                return "Your end date does not match the date format dd/mm/yyyy!";
            }
            else if (cbCustomEndDate.Checked && DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", culture) <= DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", culture))
            {
                return "Your end date must be happenned after start date!";
            }
            else if (!cbCustomEndDate.Checked && !double.TryParse(txtEndDate.Text, out testDou))
            {
                return "Your period must be a number!";
            }
            else if (!cbCustomEndDate.Checked && double.Parse(txtEndDate.Text) <= 0)
            {
                return "Your period must be greater than zero!";
            }
            else if (txtMileage.Text != "" || txtReturnDate.Text != "")
            {
                if (status == (int)RentStatus.Ready || status == (int)RentStatus.Ongoing)
                {
                    return "Your mileage and return date must be empty when status is ready or ongoing!";
                }
            }
            else if (status == (int)RentStatus.Finish)
            {
                if (txtMileage.Text == "" || txtReturnDate.Text == "")
                {
                    return "You must complete mileage and return date when status is finish!";
                }
                else if (!DateTime.TryParseExact(txtReturnDate.Text, "dd/MM/yyyy", culture, DateTimeStyles.None, out testDate))
                {
                    return "Your return date does not match the date format dd/mm/yyyy!";
                }
                else if (DateTime.ParseExact(txtReturnDate.Text, "dd/MM/yyyy", culture) <= DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", culture))
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
    }
}
