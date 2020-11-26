using System;
using System.Globalization;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarRentalManagement garage = null;

            int action;
            string next_act;
            string location;
            int capacity;
            while (true)
            {   
                action = ChooseAction();
                Console.Clear();
                switch (action)
                {
                    case 1:
                        next_act = CreateCarRentalManagementAction();
                        if (next_act == "a")
                        {
                            garage = new CarRentalManagement();
                            garage.ViewDetail();
                        } else if (next_act == "b")
                        {
                            Console.Write("Location: ");
                            location = Console.ReadLine();
                            garage = new CarRentalManagement(location);
                            garage.ViewDetail();
                        } else
                        {
                            Console.Write("Location: ");
                            location = Console.ReadLine();
                            Console.Write("Capacity: ");
                            capacity = int.Parse(Console.ReadLine());
                            garage = new CarRentalManagement(location, capacity);
                            garage.ViewDetail();
                        }
                        break;
                    case 2:
                        if (garage != null)
                        {
                            next_act = AddVehicleAction();
                            if (next_act == "a")
                            {
                                Console.WriteLine("Please fill in some vehicle information ");
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Color: ");
                                string color = Console.ReadLine();
                                Console.Write("Brand: ");
                                string brand = Console.ReadLine();
                                Console.Write("Year: ");
                                int year = int.Parse(Console.ReadLine());
                                Console.Write("Seats: ");
                                int numberOfSeat = int.Parse(Console.ReadLine());
                                Console.Write("Price per day: ");
                                double price = double.Parse(Console.ReadLine());
                                Console.Write("Condition (from 0.0 to 1.0): ");
                                double condition = double.Parse(Console.ReadLine());
                                Console.Write("Current mileage: ");
                                int curMileage = int.Parse(Console.ReadLine());
                                Console.Write("Last engine server mileage: ");
                                int engineMileage = int.Parse(Console.ReadLine());
                                Console.Write("Last transmission server mileage: ");
                                int transmissionMileage = int.Parse(Console.ReadLine());
                                Console.Write("Last tire server mileage: ");
                                int tireMileage = int.Parse(Console.ReadLine());

                                garage.AddVehicle(new Car(name, color, brand, year, numberOfSeat, price, condition, curMileage, engineMileage, transmissionMileage, tireMileage));
                            } else if (next_act == "b")
                            {
                                Console.WriteLine("Please fill in some vehicle information ");
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Color: ");
                                string color = Console.ReadLine();
                                Console.Write("Year: ");
                                int year = int.Parse(Console.ReadLine());
                                Console.Write("Price per day: ");
                                double price = double.Parse(Console.ReadLine());
                                Console.Write("Condition (from 0.0 to 1.0): ");
                                double condition = double.Parse(Console.ReadLine());
                                Console.Write("Current mileage: ");
                                int curMileage = int.Parse(Console.ReadLine());
                                Console.Write("Last engine server mileage: ");
                                int engineMileage = int.Parse(Console.ReadLine());
                                Console.Write("Last transmission server mileage: ");
                                int transmissionMileage = int.Parse(Console.ReadLine());
                                Console.Write("Last tire server mileage: ");
                                int tireMileage = int.Parse(Console.ReadLine());
                                garage.AddVehicle(new Truck(name, color, year, price, condition, curMileage, engineMileage, transmissionMileage, tireMileage));
                            } else
                            {
                                garage.AddVehicle();
                            }
                        } else
                        {
                            Console.WriteLine("Please create a garage first");
                        }
                        break;
                    case 3:
                        if (garage != null)
                        {
                            garage.ShowList();
                        } else
                        {
                            Console.WriteLine("Please create a garage first");
                        }
                        break;
                    case 4:
                        if (garage != null)
                        {
                            garage.ServeFleet();
                        }
                        else
                        {
                            Console.WriteLine("Please create a garage first");
                        }
                        break;
                    case 5:
                        if (garage != null)
                        {
                            Console.Write("Enter vehicle ID: ");
                            string id = Console.ReadLine();
                            Vehicle vehicle = garage.GetVehicle(id);
                            if (vehicle == null)
                            {
                                Console.WriteLine("Vehicle not found!!!");
                            }
                            else
                            {
                                vehicle.DisplayServiceHistory();
                                next_act = SelectMaintenanceJobAction();
                                Console.Write("First job ID: ");
                                string firstID = Console.ReadLine();
                                Console.Write("Second job ID: ");
                                string secondID = Console.ReadLine();

                                MaintenanceJob firstJob = vehicle.GetMaintenanceJob(firstID);
                                MaintenanceJob secondJob = vehicle.GetMaintenanceJob(secondID);

                                if (firstJob == null || secondJob == null)
                                {
                                    Console.WriteLine("One of these jobs not found!!!");
                                }
                                else if (next_act == "a")
                                {
                                    int result = firstJob - secondJob;
                                    Console.WriteLine("Different distance between 2 maintenance job is " + result.ToString() + "km");
                                }
                                else if (next_act == "b")
                                {
                                    bool result = firstJob > secondJob;
                                    if (result == false)
                                    {
                                        Console.WriteLine("The first job takes before the second job");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The first job takes after the second job");
                                    }
                                }
                                else
                                {
                                    bool result = firstJob < secondJob;
                                    if (result == true)
                                    {
                                        Console.WriteLine("The first job takes before the second job");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The first job takes after the second job");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please create a garage first");
                        }
                        break;
                    default:
                        Vehicle vec = garage.VehicleList[0];
                        ServiceHistory serviceHistory = vec.ServiceHistoryList;
                        MaintenanceJob job1 = serviceHistory.MaintenanceJobs[0];
                        MaintenanceJob job2 = serviceHistory.MaintenanceJobs[1];
                        int distance = job1 - job2;
                        bool greater = job1 > job2;
                        bool less = job1 < job2;
                        Console.WriteLine(distance.ToString());
                        Console.WriteLine(greater.ToString());
                        Console.WriteLine(less.ToString());
                        break;
                }
            }
            
            

            /*
            CarRentalManagement garage = CarRentalManagement.GetInstance();

            while (true) 
            { 
                string role = RoleSelection();

                if (role == "Customer")
                {
                    CustomerHandler.Start();
                } else if (role == "Staff")
                {
                    StaffHandler.Start();
                } else if (role == "Exit")
                {
                    break;
                }
            }
            //*/
        }

        static string RoleSelection()
        {
            Console.WriteLine("Please select your role to use this app");
            int choice = 0;
            while (true)
            {
                Console.WriteLine("1. Customer");
                Console.WriteLine("2. Staff");
                Console.WriteLine("3. Exit");
                choice = int.Parse(Console.ReadLine());
                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Please select only these roles");
                } else
                {
                    break;
                }
            }
            if (1 == choice)
            {
                return "Customer";
            } else if (2 == choice)
            {
                return "Staff";
            } else
            {
                return "Exit";
            }
        }

        static int ChooseAction()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Select an action to continue...");
            Console.WriteLine("1. Create new garage");
            Console.WriteLine("2. Add vehicle to garage");
            Console.WriteLine("3. Show vehicle list");
            Console.WriteLine("4. Serve fleet");
            Console.WriteLine("5. Display service history of a vehicle");
            Console.WriteLine("--------------------------------------------");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static string CreateCarRentalManagementAction()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Select an action to continue...");
            Console.WriteLine("a. Create default garage");
            Console.WriteLine("b. Initialize location to garage");
            Console.WriteLine("c. Initialize location and capacity to garage");
            Console.WriteLine("--------------------------------------------");
            string choice = Console.ReadLine();
            return choice;
        }

        static string AddVehicleAction()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Select an action to continue...");
            Console.WriteLine("a. Add new car");
            Console.WriteLine("b. Add new truck");
            Console.WriteLine("c. Add default car to garage");
            Console.WriteLine("--------------------------------------------");
            string choice = Console.ReadLine();
            return choice;
        }

        static string SelectMaintenanceJobAction()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Select an action to continue...");
            Console.WriteLine("a. Calculate distance of two maintenance job ");
            Console.WriteLine("b. Check greater than relationship of two maintenance job");
            Console.WriteLine("c. Check less than relationship of two maintenance job");
            Console.WriteLine("--------------------------------------------");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}
