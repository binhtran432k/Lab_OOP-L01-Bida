using System;

namespace CarRental {
  class ContractList : ISaleCalculator, IListManagement {
    private Contract[] _contractList;

    public double CalculateTotalSale() {
      return 0;
    }
    public double CalculateDailySale() {
      return 0;
    }
    public double CalculateMonthlySale() {
      return 0;
    }

    public void AddItem() {}
    public void RemoveItem(string itemId) {}
    public void UpdateItem(string itemId) {}
    public void ShowItemList() {}
  }
}