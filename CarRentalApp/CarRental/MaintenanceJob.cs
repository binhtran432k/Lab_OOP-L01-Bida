using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{

    public class MaintenanceJob
    {
        private static int _numberOfJob = 0;

        public string ID { get; private set; }
        public string Kind { get; set; }
        public string Type { get; set; }
        public string VehicleID { get; set; }
        public DateTime ServeTime { get; set; }
        public int Mileage { get; set; }
        public double Cost { get; set; }
        public string Garage { get; set; }
        public MaintenanceJob(string kind, string type, string vehicleID, DateTime serveTime, int mileage, double cost = 0, string garage = "")
        {
            GenerateID();
            Kind = kind;
            Type = type;
            VehicleID = vehicleID;
            ServeTime = serveTime;
            Mileage = mileage;
            Cost = cost;
            Garage = garage;
        }

        private void GenerateID()
        {
            _numberOfJob += 1;
            ID = _numberOfJob.ToString();
        }

        public override string ToString()
        {
            string detail = "Maintenance job #" + ID + "\n";
            detail += Type + " " + Kind + " service\n";
            detail += "Serve time: " + ServeTime.ToString();
            detail += "\nAt mileage: " + Mileage.ToString();
            detail += "\nCost: " + Cost.ToString();
            detail += "\nGarage: " + Garage;
            return detail;
        }

        public static int operator -(MaintenanceJob service1, MaintenanceJob service2)
        {
            try
            {
                if (service1.VehicleID == service2.VehicleID)
                {
                    return service1.Mileage - service2.Mileage;
                }
                else
                {
                    throw new Exception("Two maintenence jobs must be for same vehicle!!!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }

        public static bool operator >(MaintenanceJob service1, MaintenanceJob service2)
        {
            try
            {
                if (service1.VehicleID == service2.VehicleID)
                {
                    return service1.ServeTime > service2.ServeTime;
                }
                else
                {
                    throw new Exception("Two maintenence jobs must be for same vehicle!!!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public static bool operator <(MaintenanceJob service1, MaintenanceJob service2)
        {
            try
            {
                if (service1.VehicleID == service2.VehicleID)
                {
                    return service1.ServeTime < service2.ServeTime;
                }
                else
                {
                    throw new Exception("Two maintenence jobs must be for same vehicle!!!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
    }
}
