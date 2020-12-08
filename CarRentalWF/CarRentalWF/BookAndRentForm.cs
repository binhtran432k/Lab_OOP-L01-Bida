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
    public partial class BookAndRentForm : Form
    {
        readonly CarRentalManagement _carRentalManagement = CarRentalManagement.GetInstance();
        readonly BindingSource _vehicleBindingSource = new BindingSource();
        public BookAndRentForm()
        {
            InitializeComponent();
        }

        private void BookAndRentForm_Load(object sender, EventArgs e)
        {
            _vehicleBindingSource.DataSource = _carRentalManagement.GetAvailableVehicleList();

            vehicleGridView.AutoGenerateColumns = false;
            vehicleGridView.DataSource = _vehicleBindingSource;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            int index = vehicleGridView.SelectedRows[0].Index;
            Vehicle vec = _carRentalManagement.VehicleList[index];
            Form rentForm = new RentUserForm(vec);

            rentForm.FormClosed += (s, a) =>
            {
                _vehicleBindingSource.ResetBindings(false);
            };

            rentForm.Show();
        }
    }
}
