using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class CustomerList : IListManagement<Customer>
    {
        private static readonly List<Customer> _customerList = new List<Customer>();
        private static CustomerList _instance = null;

        public static CustomerList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CustomerList();
            }
            return _instance;
        }

        public void AddItem(Customer item)
        {
            _customerList.Add(item);
        }

        public void RemoveItem(Customer item)
        {
            _customerList.Remove(item);
        }

        public void ShowList()
        {   
            if (_customerList.Count == 0)
            {
                Console.WriteLine("There are no customers");
            }
            foreach (Customer customer in _customerList)
            {
                customer.ViewProfile();
            }
        }

        public void UpdateItem(Customer item)
        {
            Customer customer = _customerList.Find(x => x.ID == item.ID);
            customer = item;
        }
    }
}
