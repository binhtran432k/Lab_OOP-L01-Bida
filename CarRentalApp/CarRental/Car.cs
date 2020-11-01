using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class Car : Vehicle
    {
        public Car(string name, string color, string brand, int year, int numberOfSeat, double price, double condition)
        {
            GenerateID();
            Name = name;
            Color = color;
            Brand = brand;
            Year = year;
            NumberOfSeat = numberOfSeat;
            Price = price;
            Condition = condition;
            Available = true;
        }
    }
}
