using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{
    interface IBookAndRent
    {
        bool RentVehicle(string vehicleID);
        List<Vehicle> SearchVehicleByName(string name);
        List<Vehicle> SearchVehicleByBrand(string brand);
        List<Vehicle> SearchVehicleByColor(string color);
        List<Vehicle> SearchVehicleByPrice(double priceMin, double priceMax);
    }

    interface IServeFleet
    {
        string ServeFleet();
    }
}
