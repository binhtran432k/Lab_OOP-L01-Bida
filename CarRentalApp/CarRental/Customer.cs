using System;
using System.Collections.Generic;

namespace CarRental
{
    class Customer : User, ISearchVehicle, IRentVehicle
    {
        public string LicenseNum { get; }
        public DateTime ExpireDate { get; set; }

        private static readonly CustomerList _customerList = CustomerList.GetInstance();

        public Customer(string name, string phone, string licenseNum, DateTime expireDate)
        {
            GenerateID();
            Name = name;
            Phone = phone;
            LicenseNum = licenseNum;
            ExpireDate = expireDate;

            _customerList.AddItem(this);
        }

        public override void ViewProfile()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Customer #" + ID);
            Console.WriteLine(String.Format("Name: {0}", Name));
            Console.WriteLine(String.Format("Phone number: {0}", Phone));
            Console.WriteLine(String.Format("License number: {0}", LicenseNum));
        }

        public override void UpdateProfile()
        {

        }

        public void RentVehicle(Vehicle vehicle, DateTime startDate, DateTime endDate)
        {
            double total = (endDate - startDate).TotalDays * vehicle.Price;
            Contract contract = new Contract(this, vehicle, total, startDate, endDate);
            contract.PrintContract();
        }

        public void ViewRentals()
        {
            ContractList.FilterContract(ID);
        }

        public void ViewVehicleInfo(Contract contract)
        {
            contract.ViewVehicleInfo();
        }

        public void PickupVehicle(Contract contract)
        {
            contract.PickupVehicle();
        }

        public void ReturnVehicle(Contract contract)
        {
            contract.ReturnVehicle();
        }

        public void PrintContract(Contract contract)
        {
            contract.PrintContract();
        }

        public void CancelContract(Contract contract)
        {
            contract.CancelContract();
        }

        public void SearchByName(string name)
        {
        }

        public void SearchByColor(string color)
        {
        }

        public void SearchByBrand(string brand)
        {
        }
    }
}

