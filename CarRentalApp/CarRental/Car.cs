using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class Car : Vehicle
    {
        public Car(string name, string color, string brand, int year, int numberOfSeat, double price, double condition, int curMileage = 0, int engineMileage = 0, int transmissionMilage = 0, int tireMilage = 0)
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
            CurrentMileage = curMileage;
            LastEngineServiceMileage = engineMileage;
            LastTransmissionServiceMileage = transmissionMilage;
            LastTireServiceMileage = tireMilage;
        }

        public override void ServeEngine()
        {
            int distance = CurrentMileage - LastEngineServiceMileage;
            if (distance >= 400)
            {
                LastEngineServiceMileage = CurrentMileage;
                string type = "";
                if (distance >= 1000)
                {
                    type = "oil change";
                }
                else if (distance >= 500)
                {
                    type = "major";
                }
                else
                {
                    type = "minor";
                }
                Console.WriteLine(type + " service for car engine");
                ServiceHistoryList.Add(new ServiceHistory(type, CurrentMileage));
            }
        }

        public override void ServeTransmission()
        {
            int distance = CurrentMileage - LastTransmissionServiceMileage;
            if (distance >= 600)
            {
                LastTransmissionServiceMileage = CurrentMileage;
                string type = "";
                if (distance >= 2000)
                {
                    type = "fluid change";
                }
                else if (distance >= 1400)
                {
                    type = "minor";
                }
                else
                {
                    type = "overhaul";
                }
                Console.WriteLine(type + " service for car transmission");
                ServiceHistoryList.Add(new ServiceHistory(type, CurrentMileage));
            }
        }

        public override void ServeTire()
        {
            int distance = CurrentMileage - LastTireServiceMileage;
            if (distance >= 400)
            {
                LastTireServiceMileage = CurrentMileage;
                string type = "";
                if (distance >= 800)
                {
                    type = "replacement";
                }
                else
                {
                    type = "adjustment";
                }
                Console.WriteLine(type + " service for car tire");
                ServiceHistoryList.Add(new ServiceHistory(type, CurrentMileage));
            }
        }
    }
}
