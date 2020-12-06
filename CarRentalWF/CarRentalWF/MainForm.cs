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
    public partial class MainForm : Form
    {
        private Form _activeForm = null;
        public MainForm()
        {
            InitializeComponent();
            OpenChildForm(new HomeForm());
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {   
            if (!(_activeForm is HomeForm))
            {   
                OpenChildForm(new HomeForm());
            }
        }

        private void VehicleBtn_Click(object sender, EventArgs e)
        {
            if (!(_activeForm is VehicleFleetForm))
            {
                OpenChildForm(new VehicleFleetForm());
            }
        }

        private void RentalBtn_Click(object sender, EventArgs e)
        {
            if (!(_activeForm is RentalForm))
            {
                OpenChildForm(new RentalForm());
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
