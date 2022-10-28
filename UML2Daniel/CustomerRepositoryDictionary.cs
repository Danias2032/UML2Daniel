using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Daniel
{
    public class CustomerRepositoryDictionary
    {
        #region Instance fields
        private Dictionary<string, Customer> _customer;
        #endregion

        #region Properties
        public int Count
        {
            get { return _customer.Count; }
        }
        #endregion

        #region Constructor
        public CustomerRepositoryDictionary()
        {
            _customer = new Dictionary<string, Customer>();
        }
        #endregion

        #region Methods
        public void AddCustomer(Customer aCustomer)
        {
            if (!_customer.ContainsKey(aCustomer.Id))
                _customer.Add(aCustomer.Id, aCustomer);
        }

        public Customer LookupCustomer(string id)
        {
            if (_customer.ContainsKey(id))
                return _customer[id];
                    return null;
        }

        public void DeleteCustomer(string id)
        {
            if (_customer.ContainsKey(id))
                _customer.Remove(id);
        }


        public void PrintCustomer()
        {
            foreach (Customer customer in _customer.Values)
            {
                Console.WriteLine(customer); // explicit .ToString()
            }
        }

        public void UpdateCustomer(string id, Customer customerToUpdate)
        {
            if (_customer.ContainsKey(id))
                _customer[id] = customerToUpdate;
        }

        #endregion
    }
}
