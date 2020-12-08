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
    public partial class RentUserForm : Form
    {
        public RentUserForm(Vehicle vec)
        {
            InitializeComponent();
            lblID.Text = vec.ID;
            lblVehicleName.Text = vec.Name;
            lblBrand.Text = vec.Brand;
            lblColor.Text = vec.Color;
            lblYear.Text = vec.Year.ToString();
            lblSeat.Text = vec.NumberOfSeat.ToString();
            lblPrice.Text = vec.Price.ToString();
            lblCondition.Text = vec.Condition.ToString();
        }
    }
}
