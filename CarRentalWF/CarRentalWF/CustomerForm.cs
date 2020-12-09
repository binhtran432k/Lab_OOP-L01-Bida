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
    public partial class CustomerForm : Form
    {
        readonly CustomerManagement _customerManagement = CustomerManagement.GetInstance();
        readonly BindingSource _customerBindingSource = new BindingSource();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            _customerBindingSource.DataSource = _customerManagement.GetCustomerList();

            vehicleGridView.AutoGenerateColumns = false;
            vehicleGridView.DataSource = _customerBindingSource;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Form vehicleForm = new CustomerInfoForm();
            vehicleForm.FormClosed += (s, a) =>
            {
                _customerBindingSource.DataSource = _customerManagement.GetCustomerList();
            };

            vehicleForm.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int index = int.Parse(vehicleGridView.SelectedRows[0].Cells[0].Value.ToString());
            Customer customer = _customerManagement.GetCustomer(index);
            Form vehicleForm = new CustomerInfoForm(customer);
            vehicleForm.FormClosed += (s, a) =>
            {
                _customerBindingSource.DataSource = _customerManagement.GetCustomerList();
            };

            vehicleForm.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(vehicleGridView.SelectedRows[0].Cells[0].Value.ToString());
            Customer customer = _customerManagement.GetCustomer(index);
            _customerManagement.RemoveCustomer(customer);
            _customerBindingSource.DataSource = _customerManagement.GetCustomerList();
        }
    }
}
