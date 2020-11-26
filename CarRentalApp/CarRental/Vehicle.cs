using System;
using System.Collections.Generic;

namespace CarRental
{
    public abstract class Vehicle
    {

        static int NumberOfVehicle = 0;
        private static readonly CarRentalManagement garage = CarRentalManagement.GetInstance();
        public string ID { get; protected set; }
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
        public ServiceHistory ServiceHistoryList = new ServiceHistory();

        public void GenerateID()
        {
            NumberOfVehicle += 1;
            ID = NumberOfVehicle.ToString();
        }

        public virtual void ServeEngine()
        {

        }

        public virtual void ServeTransmission()
        {

        }

        public virtual void ServeTire()
        {

        }

        public void ViewDetail()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Vehicle #" + ID);
            Console.WriteLine(String.Format("Name: {0}", Name));
            Console.WriteLine(String.Format("Color: {0}", Color));
            Console.WriteLine(String.Format("Brand: {0}", Brand));
            Console.WriteLine(String.Format("Year: {0}", Year));
            Console.WriteLine(String.Format("Seats: {0}", NumberOfSeat));
            Console.WriteLine(String.Format("Condition: {0}", GetCondition()));
            Console.WriteLine(String.Format("Price per day: {0}$/day", Price));
        }

        public void UpdateVehicle(string name, string color, string brand, int year, int numberOfSeat, double price, double condition)
        {
            Name = name;
            Color = color;
            Brand = brand;
            Year = year;
            NumberOfSeat = numberOfSeat;
            Price = price;
            Condition = condition;
        }

        public void SetAvailable(bool value)
        {
            Available = value;
            garage.UpdateItem(this);
        }

        public string GetCondition()
        {
            if (Condition >= 0.8)
            {
                return "Good";
            } else if (Condition >= 0.5)
            {
                return "Normal";
            }
            return "Bad";
        }
    }
}
