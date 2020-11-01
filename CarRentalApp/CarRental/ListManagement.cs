using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class ListManagement<T> : IListManagement<T>
    {
        public List<T> ItemList {get; set;}
        public void AddItem(T item)
        {
            ItemList.Add(item);
        }

        public void RemoveItem(T item)
        {
            ItemList.Remove(item);
        }

        public void ShowList()
        {
            
        }

        public void UpdateItem(T item)
        {
            throw new NotImplementedException();
        }
    }
}
