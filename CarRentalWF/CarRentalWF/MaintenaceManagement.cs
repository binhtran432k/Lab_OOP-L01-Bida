using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{
    class MaintenaceManagement 
    {
        public string Location;
        public List<MaintenaceJob> localMaintenances= null;
        private static MaintenaceManagement _instance = null;

        public MaintenaceManagement()
        {
            Location = "BK CS2";
            localMaintenances= InitializeRawMaintenanceList();
        }

        public static MaintenaceManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MaintenaceManagement();
            }
            return _instance;
        }

            public static List<MaintenaceJob> InitializeRawMaintenanceList()
        {
            List<MaintenaceJob> mainList = new List<MaintenaceJob>
            {
                new MaintenaceJob("Replacement","Tire Service","123",new DateTime(2020,12,6),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Oil Service","123",new DateTime(2020,12,6),10000,100.00,"BK CS2"),
                new MaintenaceJob("Adjustment","Engine Service","123",new DateTime(2020,11,30),10000,100.00,"BK CS2"),
                new MaintenaceJob("Kiem tra so so","Tire Service","456",new DateTime(2020,12,6),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Tire Service","1",new DateTime(2020,5,6),10000,100.00,"BK CS2"),
                new MaintenaceJob("Kiem tra so so","Tire Service","140",new DateTime(2020,2,6),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Engine Service","999",new DateTime(2020,1,31),10000,100.00,"BK CS2"),
                new MaintenaceJob("Adjustment","Oil Service","333",new DateTime(2020,5,4),10000,100.00,"BK CS2"),
                new MaintenaceJob("Adjustment","Oil Service","1",new DateTime(2019,5,4),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Tire Service","1",new DateTime(2018,12,6),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Oil Service","1",new DateTime(2020,1,1),10000,100.00,"BK CS2"),
                new MaintenaceJob("Adjustment","Engine Service","2",new DateTime(2020,2,20),10000,100.00,"BK CS2"),
                new MaintenaceJob("Kiem tra so so","Tire Service","2",new DateTime(2019,1,3),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Tire Service","3",new DateTime(2020,7,4),10000,100.00,"BK CS2"),
                new MaintenaceJob("Kiem tra so so","Tire Service","4",new DateTime(2020,6,6),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Engine Service","5",new DateTime(2020,5,31),10000,100.00,"BK CS2"),
                new MaintenaceJob("Adjustment","Oil Service","2",new DateTime(2020,5,14),10000,100.00,"BK CS2"),
                new MaintenaceJob("Adjustment","Oil Service","3",new DateTime(2020,2,11),10000,100.00,"BK CS2"),
                new MaintenaceJob("Adjustment","Oil Service","2",new DateTime(2020,3,14),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Tire Service","6",new DateTime(2017,8,6),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Oil Service","7",new DateTime(2020,9,9),10000,100.00,"BK CS2"),
                new MaintenaceJob("Adjustment","Engine Service","6",new DateTime(2020,8,30),10000,100.00,"BK CS2"),
                new MaintenaceJob("Kiem tra so so","Tire Service","7",new DateTime(2020,8,29),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Tire Service","8",new DateTime(2020,1,2),10000,100.00,"BK CS2"),
                new MaintenaceJob("Kiem tra so so","Tire Service","6",new DateTime(2020,1,3),10000,100.00,"BK CS2"),
                new MaintenaceJob("Replacement","Engine Service","4",new DateTime(2020,4,2),10000,100.00,"BK CS2"),
                new MaintenaceJob("Adjustment","Oil Service","3",new DateTime(2020,5,15),10000,100.00,"BK CS2"),
                new MaintenaceJob("Adjustment","Oil Service","2",new DateTime(2020,5,11),10000,100.00,"BK CS2")

            };

            return mainList;
        }

    }
}
