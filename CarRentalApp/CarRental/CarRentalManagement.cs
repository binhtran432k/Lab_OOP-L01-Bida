using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class CarRentalManagement : IListManagement<Vehicle>, IServeFleet
    {
        public string Location;
        public int Capacity { get; set; }

        private static CarRentalManagement _instance = null;

        public List<Vehicle> VehicleList { get; private set; }
        public List<Rent> RentList { get; private set; }

        public CarRentalManagement()
        {
            Console.WriteLine("Default constructor for garage is called");
            Location = "128 To Hien Thanh";
            Capacity = 100;
            VehicleList = InitializeRawVehicleList();
        }

        ///*
        public CarRentalManagement(string location)
        {
            Console.WriteLine("Constructor with only location parameter for garage is called");
            Location = location;
            Capacity = 100;

            VehicleList = new List<Vehicle>();
        }

        public void ServeFleet()
        {
            foreach (Vehicle vec in VehicleList)
            {
                Console.WriteLine("Checking for vehicle #" + vec.ID);
                Console.Write("Type: ");
                if (vec is Car)
                {
                    Console.WriteLine("car");
                }
                else
                {
                    Console.WriteLine("truck");
                }
                vec.ServeEngine();
                vec.ServeTransmission();
                vec.ServeTire();
                Console.WriteLine("--------------------------------------------");
            }
        }

        public void AddVehicle()
        {
            Console.WriteLine("Default method for adding vehicle is called");
            VehicleList.Add(new Car("Ford Focus 2011", "white", "Ford", 2011, 7, 99.99, 1.0));
        }

        public void AddVehicle(Vehicle vec)
        {
            Console.WriteLine("Secondary method for adding vehicle is called");
            VehicleList.Add(vec);
        }
        

        public CarRentalManagement(string location, int capacity)
        {
            Console.WriteLine("Constructor with all parameters for garage is called");
            Location = location;
            Capacity = capacity;

            VehicleList = new List<Vehicle>();
        }
        //*/

        public void ViewDetail()
        {
            Console.WriteLine("CarRentalManagement detail: ");
            Console.WriteLine("Location: " + Location);
            Console.WriteLine("Capacity: " + Capacity);
        }

        public static CarRentalManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = null;
            }
            return _instance;
        }

        public Vehicle GetVehicle(string number)
        {
            Vehicle vec = VehicleList.Find(x => x.ID == number);
            return vec;
        }

        public void AddItem(Vehicle item)
        {
            VehicleList.Add(item);
        }

        public void RemoveItem(Vehicle item)
        {
            VehicleList.Remove(item);
        }

        public void UpdateItem(Vehicle item)
        {
            Vehicle vec = VehicleList.Find(x => x.ID == item.ID);
            vec = item;
        }

        public void ShowList()
        {   
            if (VehicleList.Count == 0)
            {
                Console.WriteLine("There are no vehicles to show");
            }
            foreach (Vehicle vec in VehicleList)
            {
                vec.ViewDetail();
            }
        }

        public void ShowAvailableVehicle()
        {
            int cnt = 0;
            foreach (Vehicle vec in VehicleList)
            {   
                if (vec.Available)
                {
                    vec.ViewDetail();
                    cnt += 1;
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine("There are no available vehicles now! Please comeback later");
            }
        }

        public static List<Vehicle> InitializeRawVehicleList()
        {
            List<Vehicle> vecList = new List<Vehicle>
            {
                new Car("Ford X2345", "black", "Ford", 2018, 7, 99.99, 1.0, 2000, 500, 1400, 1200),
                new Car("Ferrari AF512", "red", "Ferrari", 2019, 4, 68.99, 1.0),
                new Car("Vinfast Hull", "white", "Vinfast", 2018, 7, 89.99, 1.0),
                new Car("Bosche 9999", "black", "Bosche", 2018, 4, 99.99, 1.0),
                new Car("Bus", "black", "Bus", 2018, 27, 49.99, 0.9),
                new Car("Lamboghini ACBC", "yellow", "Lambo", 2015, 7, 199.99, 0.9),
                new Car("Mech 7000X", "black", "Mech", 2016, 4, 99.99, 1.0)
            };

            return vecList;
        }
    }
}
