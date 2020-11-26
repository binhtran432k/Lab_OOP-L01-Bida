using System;

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
                Console.WriteLine("Apply " + type + " service for truck engine - Time serve: " + DateTime.Now.ToString());

                Console.Write("Cost: ");
                double cost = double.Parse(Console.ReadLine());
                Console.Write("Garage: ");
                string garage = Console.ReadLine();

                ServiceHistoryList.AddJob(new MaintenaceJob(kind, type, ID, DateTime.Now, CurrentMileage, cost, garage));
            }
        }

        public override void ServeTransmission()
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
                Console.WriteLine("Apply " + type + " service for truck transmission - Time serve: " + DateTime.Now.ToString());

                Console.Write("Cost: ");
                double cost = double.Parse(Console.ReadLine());
                Console.Write("Garage: ");
                string garage = Console.ReadLine();

                ServiceHistoryList.AddJob(new MaintenaceJob(kind, type, ID, DateTime.Now, CurrentMileage, cost, garage));
            }
        }

        public override void ServeTire()
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
                Console.WriteLine("Apply " + type + " service for truck tire - Time serve: " + DateTime.Now.ToString());

                Console.Write("Cost: ");
                double cost = double.Parse(Console.ReadLine());
                Console.Write("Garage: ");
                string garage = Console.ReadLine();

                ServiceHistoryList.AddJob(new MaintenaceJob(kind, type, ID, DateTime.Now, CurrentMileage, cost, garage));
            }
        }
    }
}
