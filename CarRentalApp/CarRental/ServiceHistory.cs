using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    public class ServiceHistory
    {
        public List<MaintenanceJob> MaintenanceJobs;

        public ServiceHistory()
        {
            MaintenanceJobs = new List<MaintenanceJob>();
        }

        public void AddJob(MaintenanceJob job)
        {
            MaintenanceJobs.Add(job);
        }

        public MaintenanceJob GetMaintenanceJob(string id)
        {
            MaintenanceJob job = MaintenanceJobs.Find(x => x.ID == id);
            return job;
        }

        public void DisplayServiceHistory()
        {
            foreach (MaintenanceJob job in MaintenanceJobs)
            {
                Console.WriteLine(job.ToString());
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}
