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
    public partial class CompareAndSubtractForm : Form
    {
        readonly MaintenaceManagement _maintenaceManagement = MaintenaceManagement.GetInstance();
        public CompareAndSubtractForm()
        {
            InitializeComponent();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            try
            {
                int id1 = int.Parse(this.service1ID.Text);
                int id2 = int.Parse(this.service2ID.Text);
                MaintenaceJob job1 = null;
                MaintenaceJob job2 = null;
                List<MaintenaceJob> mainJob = _maintenaceManagement.localMaintenances;
                foreach(var job in mainJob)
                {
                    if(int.Parse(job.ID) == id1)
                    {
                        if (job1 == null) job1 = job;
                        else
                        {
                            throw new System.InvalidOperationException("Something went wrong with the Data");
                        }
                    }
                    if (int.Parse(job.ID) == id2)
                    {
                        if (job2 == null) job2 = job;
                        else
                        {
                            throw new System.InvalidOperationException("Something went wrong with the Data");
                        }
                    }
                }
                int result = job1 - job2;
                this.Result.Text = result.ToString() + " Mileage";
            }
            catch(Exception theError)
            {
                MessageBox.Show(theError.Message.ToString());
            }
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            try
            {
                int id1 = int.Parse(this.service1ID.Text);
                int id2 = int.Parse(this.service2ID.Text);
                MaintenaceJob job1 = null;
                MaintenaceJob job2 = null;
                List<MaintenaceJob> mainJob = _maintenaceManagement.localMaintenances;
                foreach (var job in mainJob)
                {
                    if (int.Parse(job.ID) == id1)
                    {
                        if (job1 == null) job1 = job;
                        else
                        {
                            throw new System.InvalidOperationException("Something went wrong with the Data");
                        }
                    }
                    if (int.Parse(job.ID) == id2)
                    {
                        if (job2 == null) job2 = job;
                        else
                        {
                            throw new System.InvalidOperationException("Something went wrong with the Data");
                        }
                    }
                }
                if(job1 == job2)
                {
                    this.Result.Text = "Two maintenance happen at the same day";
                    return;
                }
                bool result = job1 > job2;
                if (result == false)
                {
                    this.Result.Text = "The maintenance with ID = " + job1.ID + " took place first";
                }
                else
                {
                    this.Result.Text = "The maintenance with ID = " + job2.ID + " took place first";
                }
            }
            catch (Exception theError)
            {
                MessageBox.Show(theError.Message.ToString());
            }
        }
    }
}
