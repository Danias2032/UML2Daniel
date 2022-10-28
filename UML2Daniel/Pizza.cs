using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Daniel
{
    public class Pizza
    {
        #region Instance fields
        private string _name;
        private int _number;
        private double _price;
        private string _ingredient;
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        private double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Ingredient
        {
            get { return _ingredient; }
            set { _ingredient = value; }
        }
        #endregion

        #region Constructor
        public Pizza(int number, string name, double price, string ingredient)
        {
            _name = name;
            _number = number;
            _price = price;
            _ingredient = ingredient;
        }
        #endregion

        public override string ToString()
        {
            return $"Number: {_number}, Name: {_name}, Price: {_price}kr.-, Ingredient: {_ingredient}";
        }

    }
}
