using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{   
    
    public class ServiceHistory
    {
        public List<MaintenanceJob> MaintenaceJobs;

        public ServiceHistory()
        {
            MaintenaceJobs = new List<MaintenanceJob>();
        }

        public void AddJob(MaintenanceJob job)
        {
            MaintenaceJobs.Add(job);
        }

        public string View()
        {
            string history = "";
            foreach (MaintenanceJob maintenance in MaintenaceJobs)
            {
                history += maintenance.ToString();
            }
            return history;
        }
        
    }
    
}
