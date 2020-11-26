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
        private static int NumberOfRent = 0;
        public string ID { get; private set; }
        public string CustomerName { get; set; }
        public string VehicleID { get; set; }
        public double Total { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public RentStatus Status { get; set; }
        public Rent(string customerName, string vehicleID, double total, DateTime startDate, DateTime endDate, RentStatus status = RentStatus.Ready)
        {
            GenerateID();
            CustomerName = customerName;
            VehicleID = vehicleID;
            Total = total;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }
        private void GenerateID()
        {
            NumberOfRent += 1;
            ID = NumberOfRent.ToString();
        }

        public void Update(string customerName, string vehicleID, double total, DateTime startDate, DateTime endDate, RentStatus status)
        {
            CustomerName = customerName;
            VehicleID = vehicleID;
            Total = total;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }

        public void UpdateStatus()
        {
            switch (Status)
            {
                case RentStatus.Ready:
                    Status = RentStatus.Ongoing;
                    break;
                case RentStatus.Ongoing:
                    Status = RentStatus.Finish;
                    break;
                default:
                    break;
            }
        }

        public void Cancel()
        {
            if (Status < RentStatus.Finish)
            {
                Status = RentStatus.Cancel;
            }
        }

    }
}
