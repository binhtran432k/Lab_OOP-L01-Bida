using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        protected Database _database = Database.GetInstance();
        public Customer()
        {
            Name = null;
            Phone = null;
        }
        public Customer(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        public void Update(string name, string phone)
        {
            Name = name;
            Phone = phone;
            Save();
        }
        public void Save()
        {
            _database.UpdateCustomer(this);
        }
    }
}
