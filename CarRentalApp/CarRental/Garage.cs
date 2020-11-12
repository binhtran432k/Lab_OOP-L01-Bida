using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class Garage : IListManagement<Vehicle>
    {
        public string Location;
        public int Capacity { get; set; }

        private static Garage _instance = null;

        private static readonly List<Vehicle> _vehicleList = InitializeRawVehicleList();
        // private static List<Vehicle> _vehicleList = new List<Vehicle>();


        public Garage()
        {
            Console.WriteLine("Default constructor for garage is called");
            Location = "128 To Hien Thanh";
            Capacity = 100;
            // _vehicleList = new List<Vehicle>();
        }

        /*
        public Garage(string location)
        {
            Console.WriteLine("Constructor with only location parameter for garage is called");
            Location = location;
            Capacity = 100;

            _vehicleList = new List<Vehicle>();
        }

        public void AddVehicle()
        {
            Console.WriteLine("Default method for adding vehicle is called");
            _vehicleList.Add(new Car("Ford Focus 2011", "white", "Ford", 2011, 7, 99.99, 1.0));
        }

        public void AddVehicle(Vehicle vec)
        {
            Console.WriteLine("Secondary method for adding vehicle is called");
            _vehicleList.Add(vec);
        }
        

        public Garage(string location, int capacity)
        {
            Console.WriteLine("Constructor with all parameters for garage is called");
            Location = location;
            Capacity = capacity;

            _vehicleList = new List<Vehicle>();
        }
        */

        public void ViewDetail()
        {
            Console.WriteLine("Garage detail: ");
            Console.WriteLine("Location: " + Location);
            Console.WriteLine("Capacity: " + Capacity);
        }

        public static Garage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Garage();
            }
            return _instance;
        }

        public Vehicle GetVehicle(string number)
        {
            Vehicle vec = _vehicleList.Find(x => x.ID == number);
            return vec;
        }

        public static List<Vehicle> InitializeRawVehicleList()
        {
            List<Vehicle> vecList = new List<Vehicle>
            {
                new Car("Ford X2345", "black", "Ford", 2018, 7, 99.99, 1.0),
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

        public void AddItem(Vehicle item)
        {
            _vehicleList.Add(item);
        }

        public void RemoveItem(Vehicle item)
        {
            _vehicleList.Remove(item);
        }

        public void UpdateItem(Vehicle item)
        {
            Vehicle vec = _vehicleList.Find(x => x.ID == item.ID);
            vec = item;
        }

        public void ShowList()
        {   
            if (_vehicleList.Count == 0)
            {
                Console.WriteLine("There are no vehicles to show");
            }
            foreach (Vehicle vec in _vehicleList)
            {
                vec.ViewDetail();
            }
        }

        public void ShowAvailableVehicle()
        {
            int cnt = 0;
            foreach (Vehicle vec in _vehicleList)
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

        public static void SearchVehicle(int option, bool showAvailable, string value)
        {
            List<Vehicle> result;
            switch (option)
            {
                case 3:
                    if (showAvailable)
                    {
                        result = _vehicleList.FindAll(x => x.Brand.ToLower().Contains(value) && x.Available);
                    } else
                    {
                        result = _vehicleList.FindAll(x => x.Brand.ToLower().Contains(value));
                    }
                    break;
                case 2:
                    if (showAvailable)
                    {
                        result = _vehicleList.FindAll(x => x.Color.ToLower().Contains(value) && x.Available);
                    }
                    else
                    {
                        result = _vehicleList.FindAll(x => x.Color.ToLower().Contains(value));
                    }
                    break;
                default:
                    if (showAvailable)
                    {
                        result = _vehicleList.FindAll(x => x.Name.ToLower().Contains(value) && x.Available);
                    }
                    else
                    {
                        result = _vehicleList.FindAll(x => x.Name.ToLower().Contains(value));
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
    }
}
