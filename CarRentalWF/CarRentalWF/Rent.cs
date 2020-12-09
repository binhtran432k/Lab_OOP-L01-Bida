using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public int? Mileage { get; set; }
        public double Total { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public RentStatus Status { get; set; }

        private Database _database = Database.GetInstance();

        public Rent()
        {
            ReturnDate = null;
        }

        public Rent(int customerId, int vehicleId, double price, double total, DateTime startDate, DateTime endDate, DateTime? returnDate, int? mileage, RentStatus status = RentStatus.Ready)
        {
            CustomerId = customerId;
            VehicleId = vehicleId;
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = returnDate;
            Mileage = mileage;
            Total = total;
            Status = status;
        }
        public Rent(int customerId, int vehicleId, double price, double total, DateTime startDate, double period, DateTime? returnDate, int? mileage, RentStatus status = RentStatus.Ready)
        {
            CustomerId = customerId;
            VehicleId = vehicleId;
            Price = price;
            StartDate = startDate;
            EndDate = startDate.AddDays(period);
            ReturnDate = returnDate;
            Mileage = mileage;
            Total = total;
            Status = status;
        }
       public void Update(int customerId, int vehicleId, double price, double total, DateTime startDate, DateTime endDate, DateTime? returnDate, int? mileage, RentStatus status)
       {
            CustomerId = customerId;
            VehicleId = vehicleId;
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = returnDate;
            Mileage = mileage;
            Total = total;
            Status = status;
            Save();
        }
        public void Update(double total, DateTime? returnDate, int? mileage, RentStatus status)
        {
            Total = total;
            ReturnDate = returnDate;
            Mileage = mileage;
            Status = status;
            Save();
        }
        public void Update(RentStatus status)
        {
            Status = status;
            Save();
        }
        public void Update(double total, RentStatus status)
        {
            Total = total;
            Status = status;
            Save();
        }
        public void Save()
        {
            _database.UpdateRent(this);
        }
    }
}
