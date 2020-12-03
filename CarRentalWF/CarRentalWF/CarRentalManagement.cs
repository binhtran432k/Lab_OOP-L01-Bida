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
        public List<Vehicle> VehicleList { get; private set; }
        public List<Rent> RentList { get; private set; }

        private static CarRentalManagement _instance = null;

        public CarRentalManagement()
        {
            Console.WriteLine("Default constructor for garage is called");
            Location = "128 To Hien Thanh";
            Capacity = 100;
            VehicleList = InitializeRawVehicleList();
            RentList = InitializeRawRentList();
        }

        ///*
        public CarRentalManagement(string location)
        {
            Console.WriteLine("Constructor with only location parameter for garage is called");
            Location = location;
            Capacity = 100;

            VehicleList = new List<Vehicle>();
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
            foreach (Vehicle vec in VehicleList)
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

            VehicleList = new List<Vehicle>();
        }
        //*/

        public Vehicle GetVehicle(string number)
        {
            Vehicle vec = VehicleList.Find(x => x.ID == number);
            return vec;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Default method for adding vehicle is called");
            VehicleList.Add(new Car("Ford Focus 2011", "white", "Ford", 2011, 7, 99.99, 1.0));
        }

        public void AddVehicle(Car car)
        {
            VehicleList.Add(car);
        }

        public void AddVehicle(Truck truck)
        {
            VehicleList.Add(truck);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            VehicleList.Remove(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            Vehicle vec = VehicleList.Find(x => x.ID == vehicle.ID);
            vec = vehicle;
        }

        public void AddRent(Rent rent)
        {
            RentList.Add(rent);
        }

        public void RemoveRent(Rent rent)
        {
            RentList.Remove(rent);
        }

        public List<Vehicle> GetAvailableVehicle()
        {
            List<Vehicle> availableVehicleList = new List<Vehicle>();
            foreach (Vehicle vec in VehicleList)
            {
                if (vec.Available)
                {
                    availableVehicleList.Add(vec);
                }
            }
            return availableVehicleList;
        }

        public void SearchVehicle(int option, bool showAvailable, string value)
        {
            List<Vehicle> result;
            switch (option)
            {
                case 3:
                    if (showAvailable)
                    {
                        result = VehicleList.FindAll(x => x.Brand.ToLower().Contains(value) && x.Available);
                    }
                    else
                    {
                        result = VehicleList.FindAll(x => x.Brand.ToLower().Contains(value));
                    }
                    break;
                case 2:
                    if (showAvailable)
                    {
                        result = VehicleList.FindAll(x => x.Color.ToLower().Contains(value) && x.Available);
                    }
                    else
                    {
                        result = VehicleList.FindAll(x => x.Color.ToLower().Contains(value));
                    }
                    break;
                default:
                    if (showAvailable)
                    {
                        result = VehicleList.FindAll(x => x.Name.ToLower().Contains(value) && x.Available);
                    }
                    else
                    {
                        result = VehicleList.FindAll(x => x.Name.ToLower().Contains(value));
                    }
                    break;
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No vehicles found!!");
            }
            foreach (Vehicle vec in result)
            {
                vec.ViewDetail();
            }
        }

        public static List<Vehicle> InitializeRawVehicleList()
        {
            List<Vehicle> vecList = new List<Vehicle>
            {
                new Car("Ford X2345", "black", "Ford", 2018, 7, 99.99, 1.0, 2000, 0, 1800, 1500),
                new Car("Ferrari AF512", "red", "Ferrari", 2019, 4, 68.99, 1.0),
                new Car("Vinfast Hull", "white", "Vinfast", 2018, 7, 89.99, 1.0),
                new Car("Bosche 9999", "black", "Bosche", 2018, 4, 99.99, 1.0),
                new Car("Bus", "black", "Bus", 2018, 27, 49.99, 0.9),
                new Car("Lamboghini ACBC", "yellow", "Lambo", 2015, 7, 199.99, 0.9),
                new Car("Mech 7000X", "black", "Mech", 2016, 4, 99.99, 1.0),
                new Car("Truck kun", "gray", "Truck", 2013, 2, 45, 1.0)
            };

            return vecList;
        }

        public static List<Rent> InitializeRawRentList()
        {
            List<Rent> rentList = new List<Rent>
            {
                new Rent("Romado Alice", "1", 99.99, new DateTime(2019, 12, 30), new DateTime(2020, 1, 13)),
                new Rent("Amanda Simon", "2", 68.99, new DateTime(2018, 10, 30), new DateTime(2018, 11, 11), RentStatus.Ongoing),
                new Rent("Roberto Shisui", "3", 89.99, new DateTime(2019, 2, 20), new DateTime(2019, 2, 28), RentStatus.Finish),
                new Rent("John Smith", "4", 99.99, new DateTime(2020, 10, 19), new DateTime(2020, 10, 22), RentStatus.Cancel)
            };

            return rentList;
        }
    }
}
