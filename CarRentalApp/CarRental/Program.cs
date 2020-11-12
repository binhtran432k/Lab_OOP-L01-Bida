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
                    default:
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
            Console.WriteLine("4. Serve list");
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
    }
}
