using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class StaffList
    {
        private static readonly List<Staff> _staffList = new List<Staff>();
        private static StaffList _instance = null;

        public static StaffList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StaffList();
            }
            return _instance;
        }

        public void AddItem(Staff item)
        {
            _staffList.Add(item);
        }

        public void RemoveItem(Staff item)
        {
            _staffList.Remove(item);
        }

        public void ShowList()
        {
            if (_staffList.Count == 0)
            {
                Console.WriteLine("There are no customers");
            }
            foreach (Staff staff in _staffList)
            {
                staff.ViewProfile();
            }
        }

        public void UpdateItem(Staff item)
        {
            Staff staff = _staffList.Find(x => x.ID == item.ID);
            staff = item;
        }
    }
}
