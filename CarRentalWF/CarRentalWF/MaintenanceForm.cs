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
    public partial class MaintenanceForm : Form
    {
        int id = -1;
        readonly MaintenaceManagement _maintenaceManagement = MaintenaceManagement.GetInstance();

        public MaintenanceForm()
        {
            InitializeComponent();
        }
        public MaintenanceForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
            if(this.id > 0)
            {
                List<MaintenanceJob> mainJob = _maintenaceManagement.localMaintenances;
                foreach(var job in mainJob)
                {
                    if(job.VehicleID == this.id)
                    {
                        maintenaceJobBindingSource.Add(job);
                    }
                }
            }
        }

        private void CompareAndSubtractBtn_Click(object sender, EventArgs e)
        {
            CompareAndSubtractForm form = new CompareAndSubtractForm();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
               
            }
        }
    }
}
