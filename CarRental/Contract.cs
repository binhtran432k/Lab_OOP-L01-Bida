using System;

namespace CarRental {
  class Contract : IRentCar {
    private string _id;
    private string _customerId;
    private Vehicle _vehicle;
    private double _total;
    private DateTime _startDate;
    private DateTime _endDate;
    private Status _status;
    public void CreateContract() {}
    public void ViewVehicleInfo() {}
    public void PickupVehicle() {}
    public void ReturnVehicle() {}
    public void PrintContract() {}
    public void CancelContract() {}
  }
}