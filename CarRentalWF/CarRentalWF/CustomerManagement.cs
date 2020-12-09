using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWF
{
    public class CustomerManagement
    {
        private static CustomerManagement _instance = null;
        protected Database _database = Database.GetInstance();

        private CustomerManagement() { }
        public static CustomerManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CustomerManagement();
            }
            return _instance;
        }
        public Customer GetCustomer(int customerId)
        {
            return _database.GetCustomer(customerId);
        }

        public void AddCustomer(Customer customer)
        {
            _database.InsertCustomer(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            _database.RemoveCustomer(customer.Id);
        }

        public List<Customer> GetCustomerList()
        {
            return _database.GetAllCustomers();
        }
    }
}
