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
        public int Capacity { get; private set; }
        public int Count { get; private set; }
        public List<Vehicle> VehicleList { get; private set; }
        public List<Rent> RentList { get; private set; }

        private static CarRentalManagement _instance = null;

        public CarRentalManagement()
        {
            // Console.WriteLine("Default constructor for garage is called");
            Location = "128 To Hien Thanh";
            Capacity = 100;
            VehicleList = new List<Vehicle>();
            Count = 0;
            RentList = new List<Rent>();
        }

        ///*
        public CarRentalManagement(string location, int capacity = 100)
        {
            // Console.WriteLine("Constructor with all parameters for garage is called");
            Location = location;
            Capacity = capacity;

            VehicleList = new List<Vehicle>();
            Count = 0;
            RentList = new List<Rent>();
            InitializeRawData();
        }

        public static CarRentalManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CarRentalManagement("128 To Hien Thanh", 100);
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
        //*/

        public Vehicle GetVehicle(string number)
        {
            Vehicle vec = VehicleList.Find(x => x.ID == number);
            return vec;
        }

        public bool AddVehicle()
        {
            // Console.WriteLine("Default method for adding vehicle is called");
            if (Count < Capacity)
            {
                VehicleList.Add(new Car("Ford Focus 2011", "white", "Ford", 2011, 7, 99.99, 1.0));
                Count++;
                return true;
            }
            return false;
        }

        public bool AddVehicle(Car car)
        {
            if (Count < Capacity)
            {
                VehicleList.Add(car);
                Count++;
                return true;
            }
            return false;
        }

        public bool AddVehicle(Truck truck)
        {
            if (Count < Capacity)
            {
                VehicleList.Add(truck);
                Count++;
                return true;
            }
            return false;
        }
        public bool AddVehicle(string name, string type, string color, string brand, int year, int numberOfSeat, double price, double condition, int curMileage = 0, int engineMileage = 0, int transmissionMilage = 0, int tireMilage = 0)
        {
            if (Count < Capacity)
            {
                if (type == "Car")
                {
                    AddVehicle(new Car(name, color, brand, year, numberOfSeat, price, condition, curMileage, engineMileage, transmissionMilage, tireMilage));
                }
                else if (type == "Truck")
                {
                    AddVehicle(new Truck(name, color, year, price, condition, curMileage, engineMileage, transmissionMilage, tireMilage));
                }
                Count++;
                return true;
            }
            return false;
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

        public void InitializeRawData()
        {
            AddVehicle(new Car("Ford X2345", "black", "Ford", 2018, 7, 99.99, 1.0, 2000, 0, 1800, 1500));
            AddVehicle("Ferrari AF512", "Car", "red", "Ferrari", 2019, 4, 68.99, 1.0);
            AddVehicle(new Car("Vinfast Hull", "white", "Vinfast", 2018, 7, 89.99, 1.0));
            AddVehicle(new Car("Bosche 9999", "black", "Bosche", 2018, 4, 99.99, 1.0));
            AddVehicle("Bus", "Car", "black", "Bus", 2018, 27, 49.99, 0.9);
            AddVehicle(new Car("Lamboghini ACBC", "yellow", "Lambo", 2015, 7, 199.99, 0.9));
            AddVehicle(new Car("Mech 7000X", "black", "Mech", 2016, 4, 99.99, 1.0));
            AddVehicle(new Truck("Truck kun", "gray", 2013, 45, 1.0));
            AddRent(new Rent("Romado Alice", GetVehicle("1"), new DateTime(2019, 12, 30), new DateTime(2020, 1, 13)));
            AddRent(new Rent("Amanda Simon", GetVehicle("2"), new DateTime(2018, 10, 30), new DateTime(2018, 11, 11)));
            GetRent("2").UpdateStatus();
            AddRent(new Rent("Roberto Shisui", GetVehicle("3"), new DateTime(2019, 2, 20), new DateTime(2019, 2, 28)));
            GetRent("3").UpdateStatus();
            GetRent("3").UpdateStatus(3000, new DateTime(2019, 3, 30));
            AddRent(new Rent("John Smith", GetVehicle("4"), new DateTime(2020, 10, 19), new DateTime(2020, 10, 22)));
            GetRent("4").Cancel();
        }

        public List<Vehicle> GetAvailableVehicleList()
        {
            List<Vehicle> availableVehicles;
            availableVehicles = VehicleList.FindAll(x => x.Available);
            return availableVehicles;
        }
        public List<Vehicle> GetVehicleList()
        {
            List<Vehicle> vehicles;
            vehicles = VehicleList;
            return vehicles;
        }
        public Rent GetRent(string rentID)
        {
            Rent rent = RentList.Find(x => x.ID == rentID);
            return rent;
        }
        public List<Rent> GetRentList()
        {
            List<Rent> rents;
            rents = RentList;
            return rents;
        }
    }
}
