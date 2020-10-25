using System;

namespace CarRental {
  class Garage : IListManagement {
    private Vehicle[] _vehicleList;
    private string _location;
    private string _capacity;
    public void ShowAvailableVehicle() {
    }

    public void AddItem() {}
    public void RemoveItem(string itemId) {}
    public void UpdateItem(string itemId) {}
    public void ShowItemList() {}
  }
}