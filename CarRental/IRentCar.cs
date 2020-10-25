using System;

namespace CarRental {
  interface IRentCar {
    void CreateContract();
    void ViewVehicleInfo();
    void PickupVehicle();
    void ReturnVehicle();
    void PrintContract();
    void CancelContract();
  }
}