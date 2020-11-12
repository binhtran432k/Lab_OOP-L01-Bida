using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class ContractList : IListManagement<Contract>, ISaleCalculator
    {   
        private static readonly List<Contract> _contractList = new List<Contract>();
        private static ContractList _instance = null;

        public static ContractList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ContractList();
            }
            return _instance;
        }

        public void AddItem(Contract item)
        {
            _contractList.Add(item);
        }

        public void RemoveItem(Contract item)
        {
            _contractList.Remove(item);
        }

        public void ShowList()
        {
            foreach (Contract contract in _contractList)
            {
                contract.PrintContract();
            }
        }

        public void UpdateItem(Contract item)
        {
            Contract contract = _contractList.Find(x => x.ID == item.ID);
            contract = item;
        }

        public static Contract GetContract(string contractID, string customerID)
        {
            Contract contract = _contractList.Find(x => x.Customer.ID == customerID && x.ID == contractID);
            return contract;
        }

        public static void FilterContract(string customerID)
        {
            List<Contract> result = _contractList.FindAll(x => x.Customer.ID == customerID);

            if (result.Count == 0)
            {
                Console.WriteLine("You have no contracts!");
            }
            foreach (Contract contract in result)
            {
                contract.PrintContract();
            }
        }

        public double CalculateTotalSale()
        {
            throw new NotImplementedException();
        }

        public double CalculateDailySale()
        {
            throw new NotImplementedException();
        }

        public double CalculateMonthlySale()
        {
            throw new NotImplementedException();
        }
    }
}
