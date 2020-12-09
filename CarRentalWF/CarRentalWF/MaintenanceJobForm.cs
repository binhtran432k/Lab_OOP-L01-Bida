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
    public partial class MaintenanceJobForm : Form
    {
        readonly Vehicle _vehicle1;
        readonly Vehicle _vehicle2;
        readonly BindingSource _vehicleBindingSource1 = new BindingSource();
        readonly BindingSource _vehicleBindingSource2 = new BindingSource();

        public MaintenanceJobForm()
        {
            InitializeComponent();
            _vehicle1 = null;
            _vehicle2 = null;
        }

        public MaintenanceJobForm(Vehicle vehicle1)
        {
            InitializeComponent();
            _vehicle1 = vehicle1;
            _vehicle2 = null;
        }

        public MaintenanceJobForm(Vehicle vehicle1, Vehicle vehicle2)
        {
            InitializeComponent();
            _vehicle1 = vehicle1;
            _vehicle2 = vehicle2;
        }

        private void MaintenanceJobForm_Load(object sender, EventArgs e)
        {
            if (_vehicle1 != null)
            {
                gbVehicle1.Text = _vehicle1.Name;
                _vehicleBindingSource1.DataSource = _vehicle1.GetServiceHistory().MaintenaceJobs;

                maintenanceDataGridView1.AutoGenerateColumns = false;
                maintenanceDataGridView1.DataSource = _vehicleBindingSource1;
            }
            if (_vehicle2 != null)
            {
                gbVehicle2.Text = _vehicle2.Name;
                _vehicleBindingSource2.DataSource = _vehicle2.GetServiceHistory().MaintenaceJobs;

                maintenanceDataGridView2.AutoGenerateColumns = false;
                maintenanceDataGridView2.DataSource = _vehicleBindingSource2;
            }
            maintenanceDataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            maintenanceDataGridView2.Columns[5].DefaultCellStyle.Format = "N2";
        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            try
            {
                MaintenanceJob job1;
                MaintenanceJob job2;

                GetMaintenanceJob(out job1, out job2);

                int result = job1 - job2;
                txtResult.Text = result.ToString() + " Kms";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            try
            {
                MaintenanceJob job1;
                MaintenanceJob job2;

                GetMaintenanceJob(out job1, out job2);

                bool result = job1 > job2;
                if (result == false)
                {
                    txtResult.Text = "The maintenance with ID = " + job1.ID + " took place first";
                }
                else
                {
                    txtResult.Text = "The maintenance with ID = " + job2.ID + " took place first";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }

        }

        private void GetMaintenanceJob(out MaintenanceJob job1, out MaintenanceJob job2)
        {
            if (maintenanceDataGridView1.SelectedRows.Count > 2)
            {
                throw new Exception("Please select only 2 jobs to continue");
            }
            else if (maintenanceDataGridView1.SelectedRows.Count == 2)
            {
                int index1 = maintenanceDataGridView1.SelectedRows[0].Index;
                int index2 = maintenanceDataGridView1.SelectedRows[1].Index;
                job1 = _vehicle1.GetMaintenanceJob(index1);
                job2 = _vehicle1.GetMaintenanceJob(index2);
            }
            else if (_vehicle2 != null)
            {
                if (maintenanceDataGridView2.SelectedRows.Count > 2)
                {
                    throw new Exception("Please select only 2 jobs to continue");
                }
                else if (maintenanceDataGridView2.SelectedRows.Count == 2)
                {
                    int index1 = maintenanceDataGridView2.SelectedRows[0].Index;
                    int index2 = maintenanceDataGridView2.SelectedRows[1].Index;
                    job1 = _vehicle2.GetMaintenanceJob(index1);
                    job2 = _vehicle2.GetMaintenanceJob(index2);
                }
                else
                {
                    int index1 = maintenanceDataGridView1.SelectedRows[0].Index;
                    int index2 = maintenanceDataGridView2.SelectedRows[0].Index;
                    job1 = _vehicle1.GetMaintenanceJob(index1);
                    job2 = _vehicle2.GetMaintenanceJob(index2);
                }
            }
            else
            {
                throw new Exception("Please select only 2 jobs to continue");
            }
        }
    }
}
