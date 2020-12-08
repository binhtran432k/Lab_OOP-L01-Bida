using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{
    class CarRentalManagement : IServeFleet
    {
        public string Location;
        public int Capacity { get; set; }

        private static CarRentalManagement _instance = null;
        protected Database _database = Database.GetInstance();

        public CarRentalManagement()
        {
            Console.WriteLine("Default constructor for garage is called");
            Location = "128 To Hien Thanh";
            Capacity = 100;
        }

        ///*
        public CarRentalManagement(string location)
        {
            Console.WriteLine("Constructor with only location parameter for garage is called");
            Location = location;
            Capacity = 100;
        }

        public static CarRentalManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CarRentalManagement();
            }
            return _instance;
        }

        public string ServeFleet()
        {
            string serviceReport = "";
            List<Vehicle> vehicleList = GetVehicleList();
            foreach (Vehicle vec in vehicleList)
            {
                serviceReport += "Checking for vehicle #" + vec.ID;
                serviceReport += "\nType: " + vec.Type + "\n";
                serviceReport += "Name: " + vec.Name + "\n";

                string vehicleService = "";
                vehicleService += vec.ServeEngine();
                
                vehicleService += vec.ServeTransmission();

                vehicleService += vec.ServeTire();
                if (vehicleService == "")
                {
                    vehicleService = "Vehicle is up to date\n";
                }

                vehicleService += "------------------------------------------------------------------------------\n";
                serviceReport += vehicleService;
                
            }
            return serviceReport;
        }

        public CarRentalManagement(string location, int capacity)
        {
            Console.WriteLine("Constructor with all parameters for garage is called");
            Location = location;
            Capacity = capacity;

        }
        //*/

        public Vehicle GetVehicle(int number)
        {
            return _database.GetVehicle(number);
        }

        public void AddVehicle(Car car)
        {
            _database.InsertVehicle(car);
        }

        public void AddVehicle(Truck truck)
        {
            _database.InsertVehicle(truck);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            _database.RemoveVehicle(vehicle.ID);
        }

        public void AddRent(Rent rent)
        {
            _database.InsertRent(rent);
        }

        public void RemoveRent(Rent rent)
        {
            _database.RemoveRent(rent.ID);
        }

        public Rent GetRent(int rentID)
        {
            return _database.GetRent(rentID);
        }

        public List<Vehicle> GetAvailableVehicle()
        {
            return _database.GetAllVehicles(true);
        }

        public List<Vehicle> GetVehicleList()
        {
            return _database.GetAllVehicles();
        }

        public List<Rent> GetRentList()
        {
            return _database.GetAllRents();
        }
    }
}
