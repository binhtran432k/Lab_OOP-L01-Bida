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
    public partial class SearchForm : Form
    {
        readonly CarRentalManagement _carRentalManagement = CarRentalManagement.GetInstance();
        private bool _isBook;
        private bool _needAvailable;
        public Vehicle Vehicle { get; private set; }
        public List<Vehicle> VehicleList { get; private set; }
        public SearchForm(bool isBook = false, bool needAvailable = false)
        {
            InitializeComponent();
            _isBook = isBook;
            _needAvailable = needAvailable;
            Vehicle = null;
            VehicleList = null;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            typeComboBox.Items.Add("Car");
            typeComboBox.Items.Add("Truck");
            typeComboBox.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string errorMessage = _searchHandle();
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
                return;
            }
            string type = (string)typeComboBox.SelectedItem;
            string name = nameText.Text;
            string color = colorText.Text;
            string brand = brandText.Text;
            double? minPrice = null;
            double? maxPrice = null;
            if (minPriceText.Text != "")
            {
                minPrice = double.Parse(minPriceText.Text);
            }
            if (maxPriceText.Text != "")
            {
                maxPrice = double.Parse(maxPriceText.Text);
            }
            if (_isBook)
            {
                Vehicle = _carRentalManagement.BookAvailableVehicle(type, name, color, brand, minPrice, maxPrice);
                if (Vehicle != null)
                {
                    MessageBox.Show(Vehicle.ToString());
                }
                else
                {
                    MessageBox.Show("Can't find vehicle", "Error");
                    return;
                }
            }
            else
            {
                VehicleList = _carRentalManagement.SearchAvailableVehicle(type, name, color, brand, minPrice, maxPrice);
            }
            Close();
        }
        private string _searchHandle()
        {
            double testD;
            if (minPriceText.Text != "" && !double.TryParse(minPriceText.Text, out testD))
            {
                return "The min price must be a number!";
            }
            else if (maxPriceText.Text != "" && !double.TryParse(maxPriceText.Text, out testD))
            {
                return "The max price must be a number!";
            }
            return "";
        }
    }
}
