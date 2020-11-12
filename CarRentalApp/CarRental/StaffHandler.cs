using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class StaffHandler
    {
        public static void Start()
        {
            CarRentalManagement garage = CarRentalManagement.GetInstance();

            Staff staff = StaffLogin();
            Console.WriteLine("Welcome " + staff.Name);

            int action = StaffAction();
            while (action != 10)
            {
                Console.WriteLine("You choose " + action);

                switch (action)
                {
                    case 1:
                        garage.ShowList();
                        break;
                    case 2:
                        Console.WriteLine("Serch by (name/color/brand)?");
                        string option = Console.ReadLine();
                        Console.WriteLine("Enter some value to search");
                        string value = Console.ReadLine().ToLower();
                        if (option.Trim().ToLower() == "color")
                        {
                            staff.SearchByColor(value);
                        }
                        else if (option.Trim().ToLower() == "brand")
                        {
                            staff.SearchByBrand(value);
                        }
                        else
                        {
                            staff.SearchByName(value);
                        }
                        break;
                    case 3:
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

                        staff.AddVehicle(new Car(name, color, brand, year, numberOfSeat, price, condition));
                        break;
                    case 4:
                        Console.WriteLine("Please select vehicle number to remove: ");
                        string number = Console.ReadLine();
                        Vehicle vec = garage.GetVehicle(number);
                        if (vec != null && vec.Available)
                        {
                            staff.RemoveVehicle(vec);
                            Console.WriteLine("Remove vehicle successfully");
                        }
                        else
                        {
                            Console.WriteLine("The vehicle is rented by another user or doesn't exist");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Please select vehicle number to update: ");
                        number = Console.ReadLine();
                        vec = garage.GetVehicle(number);
                        if (vec != null && vec.Available)
                        {
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Color: ");
                            color = Console.ReadLine();
                            Console.Write("Brand: ");
                            brand = Console.ReadLine();
                            Console.Write("Year: ");
                            year = int.Parse(Console.ReadLine());
                            Console.Write("Seats: ");
                            numberOfSeat = int.Parse(Console.ReadLine());
                            Console.Write("Price per day: ");
                            price = double.Parse(Console.ReadLine());
                            Console.Write("Condition (from 0.0 to 1.0): ");
                            condition = double.Parse(Console.ReadLine());

                            vec.UpdateVehicle(name, color, brand, year, numberOfSeat, price, condition);
                            staff.UpdateVehicle(vec);
                            Console.WriteLine("Update vehicle successfully");
                        }
                        else
                        {
                            Console.WriteLine("The vehicle is rented by another user or doesn't exist");
                        }
                        break;
                    case 6:
                        staff.ViewAllContracts();
                        break;
                    case 7:
                        staff.ViewCustomerList();
                        break;
                    default:
                        Console.WriteLine("This feature will be supported soon!");
                        break;
                }

                action = StaffAction();
            }
        }

        static Staff StaffLogin()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What's your phone number?");
            string phone = Console.ReadLine();
            return new Staff(name, phone);
        }

        static int StaffAction()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Select an action to continue...");
            Console.WriteLine("1. View vehicles");
            Console.WriteLine("2. Search for vehicles");
            Console.WriteLine("3. Add new vehicle");
            Console.WriteLine("4. Remove a vehicle");
            Console.WriteLine("5. Update a vehicle");
            Console.WriteLine("6. View all contracts");
            Console.WriteLine("7. View customer list");
            Console.WriteLine("8. View daily report");
            Console.WriteLine("9. View monthly report");
            Console.WriteLine("10. Logout");
            Console.WriteLine("--------------------------------------------");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
