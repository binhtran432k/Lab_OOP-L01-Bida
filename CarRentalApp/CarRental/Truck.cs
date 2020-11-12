using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class Truck : Vehicle
    {
        public Truck(string name, string color, int year, double price, double condition, int curMileage = 0, int engineMileage = 0, int transmissionMilage = 0, int tireMilage = 0)
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
            CurrentMileage = curMileage;
            LastEngineServiceMileage = engineMileage;
            LastTransmissionServiceMileage = transmissionMilage;
            LastTireServiceMileage = tireMilage;
        }

        public override void ServeEngine()
        {
            int distance = CurrentMileage - LastEngineServiceMileage;
            if (distance >= 100)
            {
                LastEngineServiceMileage = CurrentMileage;
                string type = "";
                if (distance >= 800)
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
                Console.WriteLine("Apply " + type + " service for truck engine");
                ServiceHistoryList.Add(new ServiceHistory(type, CurrentMileage));
            }
        }

        public override void ServeTransmission()
        {
            int distance = CurrentMileage - LastTransmissionServiceMileage;
            if (distance >= 300)
            {
                LastTransmissionServiceMileage = CurrentMileage;
                string type = "";
                if (distance >= 2000)
                {
                    type = "fluid change";
                }
                else if (distance >= 1000)
                {
                    type = "minor";
                }
                else
                {
                    type = "overhaul";
                }
                Console.WriteLine("Apply " + type + " service for truck transmission");
                ServiceHistoryList.Add(new ServiceHistory(type, CurrentMileage));
            }
        }

        public override void ServeTire()
        {
            int distance = CurrentMileage - LastTireServiceMileage;
            if (distance >= 200)
            {
                LastTireServiceMileage = CurrentMileage;
                string type = "";
                if (distance >= 1000)
                {
                    type = "replacement";
                }
                else
                {
                    type = "adjustment";
                }
                Console.WriteLine("Apply " + type + " service for truck tire");
                ServiceHistoryList.Add(new ServiceHistory(type, CurrentMileage));
            }
        }
    }
}
