using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int NumberOfSeat { get; set; }
        public double Price { get; set; }
        public double Condition { get; set; }
        public string ConditionText { get; set; }
        public bool Available { get; set; }
        public int CurrentMileage { get; set; }
        public int LastEngineServiceMileage { get; set; }
        public int LastTransmissionServiceMileage { get; set; }
        public int LastTireServiceMileage { get; set; }
        public ServiceHistory ServiceHistory { get; set; }

        protected Database _database = Database.GetInstance();
        public ServiceHistory GetServiceHistory()
        {
            ServiceHistory.LoadMainTenanceJobs(Id);
            return ServiceHistory;
        }
        public MaintenanceJob GetMaintenanceJob(int index)
        {
            return ServiceHistory.GetMaintenanceJob(index);
        }

        public void Update(string name, string color, string brand, int year, int numberOfSeat, double price, double condition, int currentMileage)
        {
            Name = name;
            Color = color;
            Brand = brand;
            Year = year;
            NumberOfSeat = numberOfSeat;
            Price = price;
            Condition = condition;
            CurrentMileage = currentMileage;
            Save();
        }

        public void UpdateAvailable(bool value)
        {
            Available = value;
            Save();
        }

        public string GetCondition()
        {
            if (Condition >= 80)
            {
                return "Good";
            }
            else if (Condition >= 50)
            {
                return "Normal";
            }
            return "Bad";
        }

        public void Save()
        {
            _database.UpdateVehicle(this);
        }

        public override string ToString()
        {
            string detail = "";
            detail += "Vehicle #" + Id.ToString() + "\n";
            detail += string.Format("Type: {0}\n", Type);
            detail += string.Format("Name: {0}\n", Name);
            detail += string.Format("Color: {0}\n", Color);
            detail += string.Format("Brand: {0}\n", Brand);
            detail += string.Format("Year: {0}\n", Year);
            detail += string.Format("Seats: {0}\n", NumberOfSeat);
            detail += string.Format("Condition: {0}\n", GetCondition());
            detail += string.Format("Price per day: {0}$/day\n", Price);
            return detail;
        }
        public void Update(int? mileage, bool available)
        {
            if (mileage != null)
            {
                CurrentMileage = (int)mileage;
            }
            Available = available;
            Save();
        }
        public virtual string ServeEngine() { return ""; }
        public virtual string ServeTransmission() { return ""; }
        public virtual string ServeTire() { return ""; }
    }
}
