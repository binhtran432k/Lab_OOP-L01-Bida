using System;

namespace CarRental
{
    enum ContractStatus
    {
        Pending,
        Ready,
        Ongoing,
        Finish,
        Cancel
    }

    class Contract : IContract
    {
        private static int NumberOfContract = 0;
        private static readonly ContractList contractList = ContractList.GetInstance();

        public string ID { get; }
        public Customer Customer { get; set; } 
        public Vehicle Vehicle { get; set; }
        public double Total { get; set; }
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        public ContractStatus Status { get; set; }

        public Contract(Customer customer, Vehicle vehicle, double total, DateTime startDate, DateTime endDate)
        {
            ID = GenerateID();
            Customer = customer;
            Vehicle = vehicle;
            Total = total;
            StartDate = startDate;
            EndDate = endDate;
            Status = ContractStatus.Pending;
            Vehicle.SetAvailable(false);

            contractList.AddItem(this);
        }

        public void PrintContract()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Contract #" + ID);
            Console.WriteLine(String.Format("Customer: {0}", Customer.Name));
            Console.WriteLine(String.Format("Vehicle: {0}", Vehicle.Name));
            Console.WriteLine(String.Format("Total: {0: 0.00}$", Total));
            Console.WriteLine(String.Format("Pickup date: {0}", StartDate));
            Console.WriteLine(String.Format("Return date: {0}", EndDate));
            Console.WriteLine(String.Format("Status: {0}", Status.ToString()));
        }

        public void PickupVehicle()
        {
            switch (Status)
            {
                case ContractStatus.Pending:
                case ContractStatus.Ready:
                    Status = ContractStatus.Ongoing;
                    Console.WriteLine("Have a nice trip!");
                    break;
                case ContractStatus.Ongoing:
                    Console.WriteLine("The vehicle has been picked up before!");
                    break;
                case ContractStatus.Finish:
                    Console.WriteLine("This contract has finished! You can't pickup the vehicle");
                    break;
                default:
                    Console.WriteLine("This contract has been cancelled! You can't pickup the vehicle");
                    break;
            }
        }

        public void ReturnVehicle()
        {
            switch (Status)
            {
                case ContractStatus.Pending:
                case ContractStatus.Ready:
                    Console.WriteLine("The vehicle hasn't been picked up yet! Please picked up your vehicle first.");
                    break;
                case ContractStatus.Ongoing:
                    Vehicle.SetAvailable(true);
                    Status = ContractStatus.Finish;
                    Console.WriteLine("The vehicle has been returned! See you again!");
                    break;
                case ContractStatus.Finish:
                    Console.WriteLine("This contract has finished! You can't return the vehicle");
                    break;
                default:
                    Console.WriteLine("This contract has been cancelled! You can't return the vehicle");
                    break;
            }
        }

        public void ViewVehicleInfo()
        {
            Vehicle.ViewDetail();
        }

        public void CancelContract()
        {
            switch (Status)
            {
                case ContractStatus.Pending:
                case ContractStatus.Ready:
                    Status = ContractStatus.Cancel;
                    Vehicle.SetAvailable(true);
                    Console.WriteLine("You have cancelled this contract!");
                    break;
                case ContractStatus.Ongoing:
                    Console.WriteLine("Please return the vehicle first!");
                    break;
                case ContractStatus.Finish:
                    Console.WriteLine("This contract has finished!");
                    break;
                default:
                    Console.WriteLine("This contract has been cancelled before!");
                    break;
            }
        }

        public string GenerateID()
        {
            NumberOfContract += 1;
            return NumberOfContract.ToString();
        }
    }
}

