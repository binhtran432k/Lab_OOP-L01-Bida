using System;

namespace CarRental {
  interface IListManagement {
    void AddItem();
    void RemoveItem(string itemId);
    void UpdateItem(string itemId);
    void ShowItemList();
  }
}