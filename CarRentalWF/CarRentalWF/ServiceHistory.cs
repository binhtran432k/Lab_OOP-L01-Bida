using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{   
    
    public class ServiceHistory
    {
        private Database _database = Database.GetInstance();
        public List<MaintenanceJob> MaintenaceJobs { get; set; }

        public ServiceHistory()
        {
            MaintenaceJobs = new List<MaintenanceJob>();
        }

        public void AddJob(MaintenanceJob job)
        {
            MaintenaceJobs.Add(job);
        }

        public MaintenanceJob GetMaintenanceJob(int index)
        {
            return MaintenaceJobs[index];
        }

        public void LoadMainTenanceJobs(int vehicleID)
        {
            MaintenaceJobs = _database.GetMaintenanceJobs(vehicleID);
        }
        
    }
    
}
