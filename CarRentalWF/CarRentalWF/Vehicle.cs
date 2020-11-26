using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{
    public abstract class Vehicle
    {
        public class ServiceHistory
        {   
            public string ServiceKind { get; set; }
            public string Type { get; set; }
            public string VehicleID { get; set; }
            public DateTime ServeTime { get; set; }
            public int VehicleMileage { get; set; }

            public ServiceHistory(string kind, string type, string vehicleID, DateTime time, int mileage)
            {
                ServiceKind = kind;
                Type = type;
                VehicleID = vehicleID;
                ServeTime = time;
                VehicleMileage = mileage;
            }

            public override string ToString()
            {
                return "Apply " + Type + " " + ServiceKind + " service at " + ServeTime.ToString() + "\n";
            }
        }

        static int NumberOfVehicle = 0;
        public string ID { get; protected set; }
        public string Type { get; protected set; }
        public string Name { get; protected set; }
        public string Color { get; protected set; }
        public string Brand { get; protected set; }
        public int Year { get; protected set; }
        public int NumberOfSeat { get; protected set; }
        public double Price { get; protected set; }
        public double Condition { get; protected set; }
        public bool Available { get; protected set; }
        public int CurrentMileage { get; set; }
        public int LastEngineServiceMileage { get; set; }
        public int LastTransmissionServiceMileage { get; set; }
        public int LastTireServiceMileage { get; set; }
        public List<ServiceHistory> ServiceHistoryList = new List<ServiceHistory>();

        public void GenerateID()
        {
            NumberOfVehicle += 1;
            ID = NumberOfVehicle.ToString();
        }

        public virtual string ServeEngine() { return ""; }

        public virtual string ServeTransmission() { return ""; }

        public virtual string ServeTire() { return ""; }

        public void ViewDetail()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Vehicle #" + ID);
            Console.WriteLine(string.Format("Name: {0}", Name));
            Console.WriteLine(string.Format("Color: {0}", Color));
            Console.WriteLine(string.Format("Brand: {0}", Brand));
            Console.WriteLine(string.Format("Year: {0}", Year));
            Console.WriteLine(string.Format("Seats: {0}", NumberOfSeat));
            Console.WriteLine(string.Format("Condition: {0}", GetCondition()));
            Console.WriteLine(string.Format("Price per day: {0}$/day", Price));
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
        }

        public void SetAvailable(bool value)
        {
            Available = value;
        }

        public string GetCondition()
        {
            if (Condition >= 0.8)
            {
                return "Good";
            }
            else if (Condition >= 0.5)
            {
                return "Normal";
            }
            return "Bad";
        }

        public override string ToString()
        {
            string detail = "";
            detail += "Vehicle #" + ID + "\n";
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
    }
}
