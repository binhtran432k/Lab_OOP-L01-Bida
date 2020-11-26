using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    enum RentStatus
    {
        Ready,
        Ongoing,
        Finish,
        Cancel
    }
    class Rent
    {
        private static int NumberOfRent = 0;
        public string ID { get; private set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public double Total { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public RentStatus Status { get; set; }
        public Rent(Customer customer, Vehicle vehicle, double total, DateTime startDate, DateTime endDate)
        {
            GenerateID();
            Customer = customer;
            Vehicle = vehicle;
            Total = total;
            StartDate = startDate;
            EndDate = endDate;
            Status = RentStatus.Ready;
            Vehicle.SetAvailable(false);
        }
        private void GenerateID()
        {
            NumberOfRent += 1;
            ID = NumberOfRent.ToString();
        }

        public void PrintRent()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Rent #" + ID);
            Console.WriteLine(String.Format("Customer: {0}", Customer.Name));
            Console.WriteLine(String.Format("Vehicle: {0}", Vehicle.Name));
            Console.WriteLine(String.Format("Total: {0: 0.00}$", Total));
            Console.WriteLine(String.Format("Pickup date: {0}", StartDate));
            Console.WriteLine(String.Format("Return date: {0}", EndDate));
            Console.WriteLine(String.Format("Status: {0}", Status.ToString()));
        }

        public bool PickupVehicle()
        {
            switch (Status)
            {
                case RentStatus.Ready:
                    return true;
                case RentStatus.Ongoing:
                case RentStatus.Finish:
                default:
                    return false;
            }
        }

    }
}
