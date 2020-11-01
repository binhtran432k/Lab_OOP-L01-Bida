using System;

namespace CarRental
{
    public abstract class Vehicle
    {
        static int NumberOfVehicle = 0;
        private static readonly Garage garage = Garage.GetInstance();

        public string ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int NumberOfSeat { get; set; }
        public double Price { get; set; }
        public double Condition { get; set; }
        public bool Available { get; set; }

        public void GenerateID()
        {
            NumberOfVehicle += 1;
            ID = NumberOfVehicle.ToString();
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
