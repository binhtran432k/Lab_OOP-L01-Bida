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
        public Car()
        {
            Type = "Car";
        }

        public Car(string name, string color, string brand, int year, int numberOfSeat, double price, int condition, int curMileage = 0, int engineMileage = 0, int transmissionMilage = 0, int tireMilage = 0, bool available=true)
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
            Available = available;
            CurrentMileage = curMileage;
            LastEngineServiceMileage = engineMileage;
            LastTransmissionServiceMileage = transmissionMilage;
            LastTireServiceMileage = tireMilage;
            ServiceHistory = new ServiceHistory();
        }

        public override string ServeEngine()
        {
            int distance = CurrentMileage - LastEngineServiceMileage;
            string kind = "engine";
            if (distance >= 400)
            {
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

                MaintenanceJob job = serviceForm.Job;
                if (job == null)
                {
                    return "Cancel " + type + " " + kind + " service for vehicle #" + ID.ToString() + "\n";
                }
                else
                {
                    LastEngineServiceMileage = CurrentMileage;
                    ServiceHistory.AddJob(job);
                    return job.ToString();
                }
            }
            return "";
        }

        public override string ServeTransmission()
        {
            int distance = CurrentMileage - LastTransmissionServiceMileage;
            string kind = "transmission";
            if (distance >= 600)
            {
                string type;
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

                MaintenanceJob job = serviceForm.Job;
                if (job == null)
                {
                    return "Cancel " + type + " " + kind + " service for vehicle #" + ID.ToString() + "\n";
                }
                else
                {
                    LastTransmissionServiceMileage = CurrentMileage;
                    ServiceHistory.AddJob(job);
                    return job.ToString();
                }
            }
            return "";
        }

        public override string ServeTire()
        {
            int distance = CurrentMileage - LastTireServiceMileage;
            string kind = "tire";
            if (distance >= 400)
            {
                string type;
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

                MaintenanceJob job = serviceForm.Job;
                if (job == null)
                {
                    return "Cancel " + type + " " + kind + " service for vehicle #" + ID.ToString() + "\n";
                }
                else
                {
                    LastTireServiceMileage = CurrentMileage;
                    ServiceHistory.AddJob(job);
                    return job.ToString();
                }
            }
            return "";
        }
    }
}
