using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{
    class Truck : Vehicle
    {
        public Truck(string name, string color, int year, double price, double condition, int curMileage = 0, int engineMileage = 0, int transmissionMilage = 0, int tireMilage = 0)
        {
            GenerateID();
            Type = "Truck";
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

        public override string ServeEngine()
        {
            int distance = CurrentMileage - LastEngineServiceMileage;
            string kind = "engine";
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
                ServiceHistory service = new ServiceHistory(kind, type, ID, DateTime.Now, CurrentMileage);
                ServiceHistoryList.Add(service);
                return service.ToString();
            }
            return "";
        }

        public override string ServeTransmission()
        {
            int distance = CurrentMileage - LastTransmissionServiceMileage;
            string kind = "transmission";
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
                ServiceHistory service = new ServiceHistory(kind, type, ID, DateTime.Now, CurrentMileage);
                ServiceHistoryList.Add(service);
                return service.ToString();
            }
            return "";
        }

        public override string ServeTire()
        {
            int distance = CurrentMileage - LastTireServiceMileage;
            string kind = "tire";
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
                ServiceHistory service = new ServiceHistory(kind, type, ID, DateTime.Now, CurrentMileage);
                ServiceHistoryList.Add(service);
                return service.ToString();
            }
            return "";
        }
    }
}
