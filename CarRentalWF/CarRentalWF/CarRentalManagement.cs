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
        private static CarRentalManagement _instance = null;
        protected Database _database = Database.GetInstance();

        public CarRentalManagement()
        {
            Location = "128 To Hien Thanh";
            Capacity = 100;
            Count = 0;
        }

        ///*
        public CarRentalManagement(string location, int capacity = 100)
        {
            Location = location;
            Capacity = capacity;

            Count = 0;
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
            List<Vehicle> vehicleList = GetVehicleList();
            foreach (Vehicle vec in vehicleList)
            {
                serviceReport += "Checking for vehicle #" + vec.Id;
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
            _database.RemoveVehicle(vehicle.Id);
        }

        public void AddRent(Rent rent)
        {
            _database.InsertRent(rent);
        }
        public void AddRent(int customerId, Vehicle vehicle, DateTime startDate, DateTime endDate, DateTime? returnDate, int? mileage, RentStatus status = RentStatus.Ready)
        {
            double total = _generateTotal(vehicle.Price, startDate, endDate, returnDate);
            Rent rent = new Rent(customerId, vehicle.Id, vehicle.Price, total, startDate, endDate, returnDate, mileage, status);
            _database.InsertRent(rent);
            _retalVehicleHandle(rent.Id, mileage);
        }
        public void AddRent(int customerId, Vehicle vehicle, DateTime startDate, double period, DateTime? returnDate, int? mileage, RentStatus status = RentStatus.Ready)
        {
            double total = _generateTotal(vehicle.Price, startDate, startDate.AddDays(period), returnDate);
            Rent rent = new Rent(customerId, vehicle.Id, vehicle.Price, total, startDate, period, returnDate, mileage, status);
            _database.InsertRent(rent);
            _retalVehicleHandle(rent.Id, mileage);
        }
        public void UpdateRent(int customerId, int rentId, Vehicle vehicle, DateTime startDate, DateTime endDate, DateTime? returnDate, int? mileage, RentStatus status)
        {
            double total = _generateTotal(vehicle.Price, startDate, endDate, returnDate);
            GetRent(rentId).Update(customerId, vehicle.Id, vehicle.Price, total, startDate, endDate, returnDate, mileage, status);
            _retalVehicleHandle(rentId, mileage);
        }
        public void UpdateRent(int customerId, int rentId, Vehicle vehicle, DateTime startDate, double period, DateTime? returnDate, int? mileage, RentStatus status)
        {
            double total = _generateTotal(vehicle.Price, startDate, startDate.AddDays(period), returnDate);
            GetRent(rentId).Update(customerId, vehicle.Id, vehicle.Price, total, startDate, startDate.AddDays(period), returnDate, mileage, status);
            _retalVehicleHandle(rentId, mileage);
        }
        public void RemoveRent(int rentId)
        {
            _database.RemoveRent(rentId);
        }

        public Rent GetRent(int rentId)
        {
            return _database.GetRent(rentId);
        }
        public void CancelRent(int rentId)
        {
            Rent rent = GetRent(rentId);
            Vehicle vehicle = GetVehicle(rent.VehicleId);
            if (rent.Status == RentStatus.Ready)
            {
                rent.Update(0, RentStatus.Cancel);
                vehicle.UpdateAvailable(true);
            }
        }
        public List<Vehicle> GetAvailableVehicleList()
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
        public void UpdateRentalStatus(int rentId, int? mileage, DateTime? returnDate)
        {
            Rent rent = GetRent(rentId);
            switch (rent.Status)
            {
                case RentStatus.Ready:
                    rent.Update(RentStatus.Ongoing);
                    break;
                case RentStatus.Ongoing:
                    rent.Update(_generateTotal(rent.Price, rent.StartDate, rent.EndDate, returnDate), returnDate, mileage, RentStatus.Finish);
                    _retalVehicleHandle(rent.Id, mileage);
                    break;
                default:
                    break;
            }
        }
        public Vehicle BookAvailableVehicle(string type, string name, string color, string brand, double? minPrice, double? maxPrice)
        {
            Vehicle vehicle;
            if (minPrice != null && maxPrice != null)
            {
                vehicle = GetVehicleList().Find(x => x.Available == true && x.Type == type && x.Name.ToLower().Contains(name.ToLower()) && x.Color.ToLower().Contains(color.ToLower()) && x.Brand.ToLower().Contains(brand.ToLower()) && x.Price >= minPrice && x.Price <= maxPrice);
            }
            else if (minPrice != null)
            {
                vehicle = GetVehicleList().Find(x => x.Available == true && x.Type == type && x.Name.ToLower().Contains(name.ToLower()) && x.Color.ToLower().Contains(color.ToLower()) && x.Brand.ToLower().Contains(brand.ToLower()) && x.Price >= minPrice);
            }
            else if (maxPrice != null)
            {
                vehicle = GetVehicleList().Find(x => x.Available == true && x.Type == type && x.Name.ToLower().Contains(name.ToLower()) && x.Color.ToLower().Contains(color.ToLower()) && x.Brand.ToLower().Contains(brand.ToLower()) && x.Price <= maxPrice);
            }
            else
            {
                vehicle = GetVehicleList().Find(x => x.Available == true && x.Type == type && x.Name.ToLower().Contains(name.ToLower()) && x.Color.ToLower().Contains(color.ToLower()) && x.Brand.ToLower().Contains(brand.ToLower()));
            }
            return vehicle;
        }
        public List<Vehicle> SearchAvailableVehicle(string type, string name, string color, string brand, double? minPrice, double? maxPrice)
        {
            List<Vehicle> vehicles;
            if (minPrice != null && maxPrice != null)
            {
                vehicles = GetVehicleList().FindAll(x => x.Available == true && x.Type == type && x.Name.ToLower().Contains(name.ToLower()) && x.Color.ToLower().Contains(color.ToLower()) && x.Brand.ToLower().Contains(brand.ToLower()) && x.Price >= minPrice && x.Price <= maxPrice);
            }
            else if (minPrice != null)
            {
                vehicles = GetVehicleList().FindAll(x => x.Available == true && x.Type == type && x.Name.ToLower().Contains(name.ToLower()) && x.Color.ToLower().Contains(color.ToLower()) && x.Brand.ToLower().Contains(brand.ToLower()) && x.Price >= minPrice);
            }
            else if (maxPrice != null)
            {
                vehicles = GetVehicleList().FindAll(x => x.Available == true && x.Type == type && x.Name.ToLower().Contains(name.ToLower()) && x.Color.ToLower().Contains(color.ToLower()) && x.Brand.ToLower().Contains(brand.ToLower()) && x.Price <= maxPrice);
            }
            else
            {
                vehicles = GetVehicleList().FindAll(x => x.Available == true && x.Type == type && x.Name.ToLower().Contains(name.ToLower()) && x.Color.ToLower().Contains(color.ToLower()) && x.Brand.ToLower().Contains(brand.ToLower()));
            }
            return vehicles;
        }
        private void _retalVehicleHandle(int rentId, int? mileage)
        {
            Rent rent = GetRent(rentId);
            Vehicle vehicle = GetVehicle(rent.VehicleId);
            if (rent.Status == RentStatus.Finish)
            {
                vehicle.Update(mileage, true);
            }
            else
            {
                vehicle.UpdateAvailable(false);
            }
        }
        private double _generateTotal(double price, DateTime startDate, DateTime endDate, DateTime? returnDate)
        {
            double dayDifference = (endDate - startDate).TotalDays;
            double maxDayDiff = (returnDate != null && returnDate > endDate) ? ((DateTime)returnDate - startDate).TotalDays : dayDifference;
            double overrunDateCost = (maxDayDiff - dayDifference) * price * 1.2;
            double total = dayDifference * price + overrunDateCost;
            return total;
        }
    }
}
