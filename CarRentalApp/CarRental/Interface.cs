using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    interface IListManagement<T>
    {
        void AddItem(T item);
        void RemoveItem(T item);
        void UpdateItem(T item);
        void ShowList();
    }

    interface ISearchVehicle
    {
        void SearchByName(string name);
        void SearchByColor(string color);
        void SearchByBrand(string brand);
    }

    interface IRentVehicle
    {
        void ViewVehicleInfo(Contract contract);
        void PickupVehicle(Contract contract);
        void ReturnVehicle(Contract contract);
        void PrintContract(Contract contract);
        void CancelContract(Contract contract);
        void ViewRentals();
    }

    interface IContract
    {
        void ViewVehicleInfo();
        void PickupVehicle();
        void ReturnVehicle();
        void PrintContract();
        void CancelContract();
    }

    interface ISaleCalculator
    {
        double CalculateTotalSale();
        double CalculateDailySale();
        double CalculateMonthlySale();
    }

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
        void ServeFleet();
    }

    interface IReportGenerator
    {
        void GenerateDailyReport();
        void GenerateMonthlyReport();
        void ExportPdf();
        void ExportExcel();
        void PrintReport();
    }
}
