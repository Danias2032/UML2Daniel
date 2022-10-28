using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Daniel
{
    public class PizzaRepositoryList //Liste - 
    {
        #region Instance fields
        private List<Pizza> _pizza;
        #endregion

        #region Properties
        public int Count
        {
            get { return _pizza.Count; }
        }
        #endregion

        #region Constructor
        public PizzaRepositoryList()
        {
            _pizza = new List<Pizza>();
        }
        #endregion

        #region Methods

        public void AddPizza(Pizza aPizza)
        {
            //Book foundPizza = LookupPizza(aPizza.Number);
            //if (foundPizza == null)
            if (LookupPizza(aPizza.Number) == null) // Bruges hvis man ikke vil have dubletter.
                _pizza.Add(aPizza);
        }

        public Pizza LookupPizza(int number)
        {
            foreach (Pizza item in _pizza)
            {
                if (item.Number == number)
                    return item;
            }
            return null;
        }

        public void DeletePizza(int number)
        {
            Pizza item = LookupPizza(number);
            _pizza.Remove(item);
        }

        public void PrintPizza()
        {
            foreach (Pizza item in _pizza)
            {
                Console.WriteLine(item);
            }
        }

        public void UpdatePizza(int number, Pizza pizzaToUpdate)
        {
            //int upPizzaIndex = _pizza.IndexOf(LookupPizza(number));
            //_books[upPizzaIndex] = pizzaToUpdate;
            
            int d = 0;
            while (d < _pizza.Count)
            {
                if (_pizza[d].Number == number)
                {
                    _pizza[d] = pizzaToUpdate;
                    break;
                }
                d++;
            }
            #endregion
        }
    }

}
