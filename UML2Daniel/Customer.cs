using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UML2Daniel
{
    public class Customer
    {
        #region Instance fields
        private string _id;
        private string _name;
        private string _mobile;
        private string _adresse;
        #endregion

        #region Properties
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        #endregion

        #region Constructor
        public Customer(string id, string name, string adresse, string mobile)
        {
            _id = id;
            _name = name;
            _adresse = adresse;
            _mobile = mobile;
        }
        #endregion

        public override string ToString()
        {
            return $"ID: {_id}, Name: {_name}, Adresse: {_adresse}, Tlf: {_mobile}";
        }
    }
}
