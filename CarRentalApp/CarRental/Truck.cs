using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class Truck : Vehicle
    {
        public Truck(string name, string color, int year, double price, double condition)
        {
            GenerateID();
            Name = name;
            Color = color;
            Brand = "truck";
            Year = year;
            NumberOfSeat = 2;
            Price = price;
            Condition = condition;
            Available = true;
        }
    }
}
