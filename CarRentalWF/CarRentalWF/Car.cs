using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalWF
{
    class Car : Vehicle
    {
        public Car(string name, string color, string brand, int year, int numberOfSeat, double price, double condition, int curMileage = 0, int engineMileage = 0, int transmissionMilage = 0, int tireMilage = 0)
        {
            GenerateID();
            Type = "Car";
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
            ServiceHistoryList = new ServiceHistory();
        }

        public override string ServeEngine()
        {
            int distance = CurrentMileage - LastEngineServiceMileage;
            string kind = "engine";
            if (distance >= 400)
            {
                LastEngineServiceMileage = CurrentMileage;
                string type;
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

                ServiceForm serviceForm = new ServiceForm(kind, type, ID, DateTime.Now, CurrentMileage);
                serviceForm.ShowDialog();

                MaintenaceJob job = serviceForm.Job;
                ServiceHistoryList.AddJob(job);
                

                return job.ToString();
            }
            return "";
        }

        public override string ServeTransmission()
        {
            int distance = CurrentMileage - LastTransmissionServiceMileage;
            string kind = "transmission";
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

                ServiceForm serviceForm = new ServiceForm(kind, type, ID, DateTime.Now, CurrentMileage);
                serviceForm.ShowDialog();

                MaintenaceJob job = serviceForm.Job;
                ServiceHistoryList.AddJob(job);
                return job.ToString();
            }
            return "";
        }

        public override string ServeTire()
        {
            int distance = CurrentMileage - LastTireServiceMileage;
            string kind = "tire";
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

                ServiceForm serviceForm = new ServiceForm(kind, type, ID, DateTime.Now, CurrentMileage);
                serviceForm.ShowDialog();

                MaintenaceJob job = serviceForm.Job;
                ServiceHistoryList.AddJob(job);
                return job.ToString();
            }
            return "";
        }
    }
}
