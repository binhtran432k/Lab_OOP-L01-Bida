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
        public Nullable<int> Mileage { get; set; }
        public double Total { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Nullable<DateTime> ReturnDate { get; set; }
        public RentStatus Status { get; set; }
        private Vehicle _vehicle;

        public Rent(string customerName, Vehicle vehicle, DateTime startDate, DateTime endDate, RentStatus status = RentStatus.Ready)
        {
            GenerateID();
            CustomerName = customerName;
            _vehicle = vehicle;
            VehicleID = vehicle.ID;
            Mileage = null;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = null;
            Total = _generateTotal(vehicle.Price, startDate, endDate);
            Status = status;
        }

        public Rent(string customerName, Vehicle vehicle, int mileage, DateTime startDate, DateTime endDate, DateTime returnDate, RentStatus status = RentStatus.Ready)
        {
            GenerateID();
            CustomerName = customerName;
            _vehicle = vehicle;
            VehicleID = vehicle.ID;
            Mileage = mileage;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = returnDate;
            Total = _generateTotal(vehicle.Price, mileage, startDate, endDate, returnDate);
            Status = status;
        }
        public Rent(string customerName, Vehicle vehicle, DateTime startDate, double period, RentStatus status = RentStatus.Ready)
        {
            GenerateID();
            CustomerName = customerName;
            _vehicle = vehicle;
            VehicleID = vehicle.ID;
            Mileage = null;
            StartDate = startDate;
            DateTime endDate = startDate.AddDays(period);
            EndDate = endDate;
            ReturnDate = null;
            Total = _generateTotal(vehicle.Price, startDate, endDate);
            Status = status;
        }

        public Rent(string customerName, Vehicle vehicle, int mileage, DateTime startDate, double period, DateTime returnDate, RentStatus status = RentStatus.Ready)
        {
            GenerateID();
            CustomerName = customerName;
            _vehicle = vehicle;
            VehicleID = vehicle.ID;
            Mileage = mileage;
            StartDate = startDate;
            DateTime endDate = startDate.AddDays(period);
            EndDate = endDate;
            ReturnDate = returnDate;
            Total = _generateTotal(vehicle.Price, mileage, startDate, endDate, returnDate);
            Status = status;
        }
        private void GenerateID()
        {
            NumberOfRent += 1;
            ID = NumberOfRent.ToString();
        }
        public void Update(string customerName, DateTime startDate, DateTime endDate, RentStatus status)
        {
            CustomerName = customerName;
            VehicleID = _vehicle.ID;
            Mileage = null;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = null;
            Total = _generateTotal(_vehicle.Price, startDate, endDate);
            Status = status;
        }
        public void Update(string customerName, int mileage, DateTime startDate, DateTime endDate, DateTime returnDate, RentStatus status)
        {
            CustomerName = customerName;
            VehicleID = _vehicle.ID;
            Mileage = mileage;
            StartDate = startDate;
            EndDate = endDate;
            ReturnDate = returnDate;
            Total = _generateTotal(_vehicle.Price, mileage, startDate, endDate, returnDate);
            Status = status;
        }
        public void Update(string customerName, DateTime startDate, double period, RentStatus status)
        {
            CustomerName = customerName;
            VehicleID = _vehicle.ID;
            Mileage = null;
            StartDate = startDate;
            DateTime endDate = startDate.AddDays(period);
            EndDate = endDate;
            ReturnDate = null;
            Total = _generateTotal(_vehicle.Price, startDate, endDate);
            Status = status;
        }
        public void Update(string customerName, int mileage, DateTime startDate, double period, DateTime returnDate, RentStatus status)
        {
            CustomerName = customerName;
            VehicleID = _vehicle.ID;
            Mileage = mileage;
            StartDate = startDate;
            DateTime endDate = startDate.AddDays(period);
            EndDate = endDate;
            ReturnDate = returnDate;
            Total = _generateTotal(_vehicle.Price, mileage, startDate, endDate, returnDate);
            Status = status;
        }

        public void UpdateStatus(int mileage, DateTime returnDate)
        {
            if (Status == RentStatus.Ongoing)
            {
                Status = RentStatus.Finish;
                _vehicle.SetAvailable(true);
                Update(CustomerName, mileage, StartDate, EndDate, returnDate, Status);
            }
        }
        public void UpdateStatus()
        {
            switch (Status)
            {
                case RentStatus.Ready:
                    Status = RentStatus.Ongoing;
                    _vehicle.SetAvailable(false);
                    break;
                case RentStatus.Ongoing:
                    Status = RentStatus.Finish;
                    _vehicle.SetAvailable(true);
                    break;
                default:
                    break;
            }
        }

        public void Cancel()
        {
            if (Status == RentStatus.Ready)
            {
                Total = 0;
                Status = RentStatus.Cancel;
                _vehicle.SetAvailable(true);
            }
        }

        private double _generateTotal(double price, int mileage, DateTime startDate, DateTime endDate, DateTime returnDate)
        {
            double dayDifference = (endDate - startDate).TotalDays;
            double maxDayDiff = (returnDate > endDate) ? (returnDate - startDate).TotalDays : (endDate - startDate).TotalDays;
            double overrunDateCost = (maxDayDiff - dayDifference) * price * 1.5;
            double overrunMileageCost = (mileage > 200 * maxDayDiff) ? (mileage / 200 - maxDayDiff) * price * 1.25 : 0;
            double total = dayDifference * price + overrunDateCost + overrunMileageCost;
            return total;
        }

        private double _generateTotal(double price, DateTime startDate, DateTime endDate)
        {
            double dayDifference = (endDate - startDate).TotalDays;
            double total = dayDifference * price;
            return total;
        }
    }
}
