using System;

namespace CarRental {
  class Customer : User, IRentCar {
    private string _licenseNo;
    private string _expireDate;
    public void ViewMyRentals() {
    }
    public override void Login() {
    }
    public override void Logout() {
    }
    public override void ViewProfile() {
    }
    public override void UpdateProfile() {
    }
    public override void ViewCarList() {
    }
    public void CreateContract() {}
    public void ViewVehicleInfo() {}
    public void PickupVehicle() {}
    public void ReturnVehicle() {}
    public void PrintContract() {}
    public void CancelContract() {}
  }
}