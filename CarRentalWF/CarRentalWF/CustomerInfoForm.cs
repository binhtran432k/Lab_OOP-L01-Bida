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
    public partial class CustomerInfoForm : Form
    {
        readonly CustomerManagement _customerManagement = CustomerManagement.GetInstance();
        Customer _customer = null;
        public CustomerInfoForm()
        {
            InitializeComponent();
        }
        public CustomerInfoForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;

            txtCustomer.Text = customer.Name;
            txtPhone.Text = customer.Phone;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = _customerInfoHandle();
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
                return;
            }
            string name = txtCustomer.Text;
            string phone = txtPhone.Text;
            if (_customer == null)
            {
                Customer customer = new Customer(name, phone);
                _customerManagement.AddCustomer(customer);
            }
            else
            {
                _customer.Update(name, phone);
            }
            Close();
        }
        private string _customerInfoHandle()
        {
            if (txtCustomer.Text == "")
            {
                return "You must complete the name field!";
            }
            else if (txtPhone.Text == "")
            {
                return "You must complete the phone field!";
            }
            return "";
        }
    }
}
