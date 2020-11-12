using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CarRental
{
    class CustomerHandler
    {
        public static void Start()
        {
            CarRentalManagement garage = CarRentalManagement.GetInstance();

            Customer customer = LoginAction();
            Console.WriteLine("Welcome " + customer.Name);

            int action = CustomerAction();
            CultureInfo culture = CultureInfo.InvariantCulture;
            while (action != 9)
            {
                Console.WriteLine("You choose " + action);

                switch (action)
                {
                    case 1:
                        garage.ShowAvailableVehicle();
                        break;
                    case 2:
                        Console.WriteLine("Serch by (name/color/brand)?");
                        string option = Console.ReadLine();
                        Console.WriteLine("Enter some value to search");
                        string value = Console.ReadLine();

                        if (option.Trim().ToLower() == "color")
                        {
                            customer.SearchByColor(value);
                        }
                        else if (option.Trim().ToLower() == "brand")
                        {
                            customer.SearchByBrand(value);
                        }
                        else
                        {
                            customer.SearchByName(value);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please select vehicle number: ");
                        string number = Console.ReadLine();
                        Vehicle rentVec = garage.GetVehicle(number);

                        if (rentVec != null && rentVec.Available)
                        {
                            DateTime startDate, endDate;
                            string dateString;
                            while (true)
                            {
                                Console.Write("Pickup date (dd/mm/yyyy):");
                                dateString = Console.ReadLine();
                                startDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", culture);

                                Console.Write("Return date (dd/mm/yyyy):");
                                dateString = Console.ReadLine();
                                endDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", culture);
                                if (endDate > startDate)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Return date must be greater than pickup date. Please enter again");
                                }
                            }
                            customer.RentVehicle(rentVec, startDate, endDate);
                        }
                        else
                        {
                            Console.WriteLine("The vehicle is rented by another user or doesn't exist");
                        }
                        break;
                    case 4:
                        customer.ViewRentals();
                        break;
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Please select contract number: ");
                        number = Console.ReadLine();
                        Contract contract = ContractList.GetContract(number, customer.ID);
                        if (contract != null)
                        {
                            if (action == 5)
                            {
                                customer.PickupVehicle(contract);
                            }
                            else if (action == 6)
                            {
                                customer.ReturnVehicle(contract);
                            }
                            else if (action == 7)
                            {
                                customer.CancelContract(contract);
                            }
                            else
                            {
                                customer.ViewVehicleInfo(contract);
                            }
                        }
                        else
                        {
                            Console.WriteLine("The contract doesn't exist");
                        }
                        break;
                    default:
                        Console.WriteLine("This feature will be supported soon!");
                        break;
                }

                action = CustomerAction();
            }
        }
        static Customer LoginAction()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What's your phone number?");
            string phone = Console.ReadLine();
            return new Customer(name, phone, "", DateTime.Now);
        }

        static int CustomerAction()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Select an action to continue...");
            Console.WriteLine("1. View vehicles");
            Console.WriteLine("2. Search for vehicles");
            Console.WriteLine("3. Rent vehicle");
            Console.WriteLine("4. View my rentals");
            Console.WriteLine("5. Pickup vehicle");
            Console.WriteLine("6. Return vehicle");
            Console.WriteLine("7. Cancel a contract");
            Console.WriteLine("8. View vehicle info in contract");
            Console.WriteLine("9. Logout");
            Console.WriteLine("--------------------------------------------");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }

    
}
