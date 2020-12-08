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
        private Database _database = Database.GetInstance();

        private static int NumberOfRent = 0;
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public double Total { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public RentStatus Status { get; set; }

        public Rent()
        {
            ReturnDate = null;
        }

        public Rent(int customerId, int vehicleID, double pricePerDay, DateTime startDate, DateTime endDate)
        {
            GenerateID();
            CustomerID = customerId;
            VehicleID = vehicleID;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = null;
            Total = (endDate - startDate).TotalDays * pricePerDay;
            Status = RentStatus.Ready;
        }

        public Rent(int customerId, int vehicleID, double pricePerDay, DateTime endDate)
        {
            GenerateID();
            CustomerID = customerId;
            VehicleID = vehicleID;
            StartDate = DateTime.Today;
            EndDate = endDate;
            ReturnDate = null;
            Total = (endDate - StartDate).TotalDays * pricePerDay;
            Status = RentStatus.Ready;
        }

        public Rent(int customerId, int vehicleID, double pricePerDay)
        {
            GenerateID();
            CustomerID = customerId;
            VehicleID = vehicleID;
            StartDate = DateTime.Today;
            EndDate = DateTime.Today.AddDays(1);
            ReturnDate = null;
            Total = pricePerDay;
            Status = RentStatus.Ready;
        }

        public Rent(int customerId, int vehicleID, double pricePerDay, DateTime startDate, DateTime endDate, RentStatus status)
        {
            GenerateID();
            CustomerID = customerId;
            VehicleID = vehicleID;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = null;
            Total = (endDate - startDate).TotalDays * pricePerDay;
            Status = status;
        }

        private void GenerateID()
        {
            NumberOfRent += 1;
            ID = NumberOfRent;
        }

        public void Update(int customerId, int vehicleID, double total, DateTime startDate, DateTime endDate, RentStatus status)
        {
            CustomerID = customerId;
            VehicleID = vehicleID;
            Total = total;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            Save();
        }

        public void UpdateStatus()
        {
            switch (Status)
            {
                case RentStatus.Ready:
                    Status = RentStatus.Ongoing;
                    Save();
                    break;
                case RentStatus.Ongoing:
                    Status = RentStatus.Finish;
                    ReturnDate = DateTime.Now;
                    Vehicle vehicle = _database.GetVehicle(VehicleID);
                    vehicle.UpdateAvailable(true);
                    Save();
                    break;
                default:
                    break;
            }
        }

        public void Cancel()
        {
            if (Status == RentStatus.Ready)
            {
                Status = RentStatus.Cancel;
                Save();
            }
        }

        public void Save()
        {
            _database.UpdateRent(this);
        }

    }
}
