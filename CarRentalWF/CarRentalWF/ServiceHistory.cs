using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{   
    
    public class ServiceHistory
    {
        public List<MaintenaceJob> MaintenaceJobs;

        public ServiceHistory()
        {
            MaintenaceJobs = new List<MaintenaceJob>();
        }

        public void AddJob(MaintenaceJob job)
        {
            MaintenaceJobs.Add(job);
        }
    }
    
}
