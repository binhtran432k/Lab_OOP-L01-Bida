using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{
    interface IBookAndRent
    {
        void RentVehicle(int customerId, Vehicle vehicle, DateTime startDate, DateTime endDate);
        Vehicle BookAvailableVehicle(string type, string name, string color, string brand, double? minPrice, double? maxPrice);
        List<Vehicle> SearchAvailableVehicle(string type, string name, string color, string brand, double? minPrice, double? maxPrice);
    }
}
