using System;

namespace CarRentalWF
{
    public enum RentStatus
    {
        Ready,
        Ongoing,
        Finish,
        Cancel
    }
    public class Rent
    {
        private static int NumberOfRent = 0;
        public string Id { get; private set; }
        public string CustomerName { get; private set; }
        public string VehicleId { get; private set; }
        public int? Mileage { get; private set; }
        public double Total { get; private set; }
        public double Price { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public RentStatus Status { get; private set; }
     
        public Rent(string customerName, string vehicleId, double price, double total, DateTime startDate, DateTime endDate, DateTime? returnDate, int? mileage, RentStatus status = RentStatus.Ready)
        {
            GenerateID();
            Update(customerName, vehicleId, price, total, startDate, endDate, returnDate, mileage, status);
        }
        public Rent(string customerName, string vehicleId, double price, double total, DateTime startDate, double period, DateTime? returnDate, int? mileage, RentStatus status = RentStatus.Ready)
        {
            GenerateID();
            Update(customerName, vehicleId, price, total, startDate, startDate.AddDays(period), returnDate, mileage, status);
        }
        private void GenerateID()
        {
            NumberOfRent += 1;
            Id = NumberOfRent.ToString();
        }
       public void Update(string customerName, string vehicleId, double price, double total, DateTime startDate, DateTime endDate, DateTime? returnDate, int? mileage, RentStatus status)
       {
            CustomerName = customerName;
            VehicleId = vehicleId;
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = returnDate;
            Mileage = mileage;
            Total = total;
            Status = status;
       }
        public void Update(double total, DateTime? returnDate, int? mileage, RentStatus status)
        {
            Total = total;
            ReturnDate = returnDate;
            Mileage = mileage;
            Status = status;
        }
        public void Update(RentStatus status)
        {
            Status = status;
        }
        public void Update(double total, RentStatus status)
        {
            Total = total;
            Status = status;
        }
    }
}
