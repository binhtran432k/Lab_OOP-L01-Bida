using System;

namespace CarRental
{
    class Staff : User, ISearchVehicle
    {
        private static readonly Garage garage = Garage.GetInstance();
        public Staff(string name, string phone)
        {
            GenerateID();
            Name = name;
            Phone = phone;
        }

        public override void ViewProfile()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Staff #" + ID);
            Console.WriteLine(String.Format("Name: {0}", Name));
            Console.WriteLine(String.Format("Phone number: {0}", Phone));
        }

        public override void UpdateProfile()
        {
            
        }

        public void ViewCustomerList()
        {
            CustomerList.GetInstance().ShowList();
        }

        public void ViewAllContracts()
        {
            ContractList.GetInstance().ShowList();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            garage.AddItem(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            garage.UpdateItem(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            garage.RemoveItem(vehicle);
        }

        public void SearchByName(string name)
        {
            Garage.SearchVehicle(1, false, name);
        }

        public void SearchByColor(string color)
        {
            Garage.SearchVehicle(2, false, color);
        }

        public void SearchByBrand(string brand)
        {
            Garage.SearchVehicle(3, false, brand);
        }
    }
}

