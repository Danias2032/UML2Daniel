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
        private Dictionary<int, Pizza> _pizza;
        #endregion

        #region Properties
        public int Count
        {
            get { return _pizza.Count; }
        }
        #endregion

        #region Constructor
        public CustomerRepositoryDictionary()
        {
            _pizza = new Dictionary<int, Pizza>();
        }
        #endregion

        #region Methods
        public void AddPizza(Pizza aPizza)
        {
            if (!_pizza.ContainsKey(aPizza.Number))
                _pizza.Add(aPizza.Number, aPizza);
        }

        public Pizza LookupPizza(int number)
        {
            if (_pizza.ContainsKey(number))
                return _pizza[number];
            return null;
        }

        public void DeletePizza(int number)
        {
            if (_pizza.ContainsKey(number))
                _pizza.Remove(number);
        }


        public void PrintPizza()
        {
            foreach (Pizza pizza in _pizza.Values)
            {
                Console.WriteLine(pizza); // explicit .ToString()
            }
        }

        public void UpdatePizza(int number, Pizza pizzaToUpdate)
        {
            if (_pizza.ContainsKey(number))
                _pizza[number] = pizzaToUpdate;
        }

        #endregion
    }
}
