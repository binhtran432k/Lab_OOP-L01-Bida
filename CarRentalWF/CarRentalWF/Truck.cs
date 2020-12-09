using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{
    class Truck : Vehicle
    {
        public Truck() { }
        public Truck(string name, string color, int year, double price, int condition, int curMileage = 0, int engineMileage = 0, int transmissionMilage = 0, int tireMilage = 0, bool available=true)
        {
            Type = "Truck";
            Name = name;
            Color = color;
            Brand = "";
            Year = year;
            NumberOfSeat = 2;
            Price = price;
            Condition = condition;
            ConditionText = GetCondition();
            Available = available;
            CurrentMileage = curMileage;
            LastEngineServiceMileage = engineMileage;
            LastTransmissionServiceMileage = transmissionMilage;
            LastTireServiceMileage = tireMilage;
            ServiceHistoryList = new ServiceHistory();
        }

        public override string ServeEngine()
        {
            int distance = CurrentMileage - LastEngineServiceMileage;
            string kind = "engine";
            if (distance >= 100)
            {
                string type;
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
                ServiceForm serviceForm = new ServiceForm(kind, type, Id, DateTime.Now, CurrentMileage);
                serviceForm.ShowDialog();

                MaintenanceJob job = serviceForm.Job;
                if (job == null)
                {
                    return "Cancel " + type + " " + kind + " service for vehicle #" + Id.ToString() + "\n";
                }
                else
                {
                    LastEngineServiceMileage = CurrentMileage;
                    ServiceHistoryList.AddJob(job);
                    return job.ToString();
                }
            }
            return "";
        }

        public override string ServeTransmission()
        {
            int distance = CurrentMileage - LastTransmissionServiceMileage;
            string kind = "transmission";
            if (distance >= 300)
            {
                string type;
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
                ServiceForm serviceForm = new ServiceForm(kind, type, Id, DateTime.Now, CurrentMileage);
                serviceForm.ShowDialog();

                MaintenanceJob job = serviceForm.Job;
                if (job == null)
                {
                    return "Cancel " + type + " " + kind + " service for vehicle #" + Id.ToString() + "\n";
                }
                else
                {
                    LastTransmissionServiceMileage = CurrentMileage;
                    ServiceHistoryList.AddJob(job);
                    return job.ToString();
                }
            }
            return "";
        }

        public override string ServeTire()
        {
            int distance = CurrentMileage - LastTireServiceMileage;
            string kind = "tire";
            if (distance >= 200)
            {
                string type;
                if (distance >= 1000)
                {
                    type = "replacement";
                }
                else
                {
                    type = "adjustment";
                }
                ServiceForm serviceForm = new ServiceForm(kind, type, Id, DateTime.Now, CurrentMileage);
                serviceForm.ShowDialog();

                MaintenanceJob job = serviceForm.Job;
                if (job == null)
                {
                    return "Cancel " + type + " " + kind + " service for vehicle #" + Id.ToString() + "\n";
                }
                else
                {
                    LastTireServiceMileage = CurrentMileage;
                    ServiceHistoryList.AddJob(job);
                    return job.ToString();
                }
            }
            return "";
        }
    }
}
