using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UML2Daniel
{
    public class Menu
    {
        private PizzaRepositoryList _pizzaRepositoryList;
        private CustomerRepositoryDictionary _customerRepositoryDictionary;
        public Menu(PizzaRepositoryList pizzaRepositoryList, CustomerRepositoryDictionary customerRepositoryDictionary)
        {
            _pizzaRepositoryList = pizzaRepositoryList;
            _customerRepositoryDictionary = customerRepositoryDictionary;
        }

        public int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\t---------------CRUD Listoperationer--------------------");
            Console.WriteLine("\t1.\tTilføj Pizza til PizzaRepositoryList");
            Console.WriteLine("\t2.\tUdskriv alle pizzaer fra PizzaRepositoryList");
            Console.WriteLine("\t3.\tSøg efter en pizza i PizzaRepositoryList udfra Number");
            Console.WriteLine("\t4.\tFjern pizza fra PizzaRepositoryList");
            Console.WriteLine("\t5.\tOpdater pizza i PizzaRepositoryList");
            Console.WriteLine("\t---------------CRUD Dictionaryoperationer--------------------");
            Console.WriteLine("\t6.\tTilføj customer til CustomerRepositoryDictionary");
            Console.WriteLine("\t7.\tUdskriv alle customers fra CustomerRepositoryDictionary");
            Console.WriteLine("\t8.\tSøg efter en customer i CustomerRepositoryDictionary udfra ID");
            Console.WriteLine("\t9.\tFjern customer i CustomerRepositoryDictionary");
            Console.WriteLine("\t10.\tOpdater customer fra CustomerRepositoryDictionary");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tTast 0 for afslut");
            Console.WriteLine("\t-----------------------------------");
            Console.Write("\tIndtast dit valg:");
            return ReadUserChoice();
        }

        public void Run()
        {
            int valg = ShowMenu();
            while (valg != 0)
            {
                switch (valg)
                {
                    case 1:
                        Console.Clear();
                        AddPizzaToList();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Print Pizza");
                        _pizzaRepositoryList.PrintPizza();
                        break;
                    case 3:
                        Console.Clear();
                        SearchPizzaList();
                        break;
                    case 4:
                        Console.Clear();
                        DeletePizzaFromList();
                        break;
                    case 5:
                        Console.Clear();
                        UpdatePizzaList();
                        break;
                    case 6:
                        Console.Clear();
                        AddCustomerToDictionary();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Print Customer");
                        _customerRepositoryDictionary.PrintCustomer();
                        break;
                    case 8:
                        Console.Clear();
                        SearchCustomerDictionary();
                        break;
                    case 9:
                        Console.Clear();
                        DeleteCustomerFromDictionary();
                        break;
                    case 10:
                        Console.Clear();
                        UpdateCustomerDictionary();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Fejl i input");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                valg = ShowMenu();

            }

        }
        // Liste Menu
        private void AddPizzaToList()
        {
            Console.WriteLine("Tilføj ny Pizza");
            Console.WriteLine("Indtast Number");
            int number = int.Parse (Console.ReadLine());
            Console.WriteLine("Indtast Name");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast Price");
            double price = double.Parse (Console.ReadLine());
            Console.WriteLine("Indtast Ingredient(s)");
            string ingredient = Console.ReadLine();
            Pizza p = new Pizza(number, name, price, ingredient);
            _pizzaRepositoryList.AddPizza(p);
        }

        private void SearchPizzaList()
        {
            Console.WriteLine("Søg efter Pizza");
            Console.WriteLine("Indtast Pizza");
            int number = int.Parse (Console.ReadLine());
            Pizza pizza = _pizzaRepositoryList.LookupPizza(number);
            if (pizza == null)
            {
                Console.WriteLine("Pizzaen eksistere ikke");
            }
            else
            {
                Console.WriteLine(pizza);
            }
            Console.ReadLine();
        }

        private void DeletePizzaFromList() 
        {
            Console.WriteLine("Slet Pizza fra Menuen");
            Console.WriteLine("Indsæt Number");
            int number = int.Parse (Console.ReadLine());
            _pizzaRepositoryList.DeletePizza(number);
        }

        private void UpdatePizzaList()
        {
            Console.WriteLine("Update Pizza");
            Console.WriteLine("Indsæt Name");
            int numberOld = int.Parse(Console.ReadLine());
            Pizza pizza = _pizzaRepositoryList.LookupPizza(numberOld);
            if (pizza == null)
            {
                Console.WriteLine("Pizzaen eksistere ikke");
            }
            else
            {
                Console.WriteLine("Update Pizza");
                Console.WriteLine("Indsæt Number");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Indsæt Name");
                string name = Console.ReadLine();
                Console.WriteLine("Indsæt Price");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Indsæt Ingredient(s)");
                string ingredient = Console.ReadLine();

                Pizza updatedPizza = new Pizza(number, name, price, ingredient);

                _pizzaRepositoryList.UpdatePizza(numberOld, updatedPizza);
                Console.WriteLine("Pizza Updated");
                Console.ReadLine();
            }
        }


        // Dictionary Menu
        private void AddCustomerToDictionary()
        {
             Console.WriteLine("Tilføj ny Customer");
             Console.WriteLine("Indtast ID");
             string id = Console.ReadLine();
             Console.WriteLine("Indtast Name");
             string name = Console.ReadLine();
             Console.WriteLine("Indtast Adresse");
             string adresse = Console.ReadLine();
             Console.WriteLine("Indtast Mobile Nr.");
             string mobile = Console.ReadLine();
             Customer c = new Customer(id, name, adresse, mobile);
             _customerRepositoryDictionary.AddCustomer(c);
        }

        private void SearchCustomerDictionary()
        {
            Console.WriteLine("Søg efter Customer");
            Console.WriteLine("Indtast Customer");
            string id = Console.ReadLine();
            Customer customer = _customerRepositoryDictionary.LookupCustomer(id);
            if (customer == null)
            {
                Console.WriteLine("Customer eksistere ikke");
            }
            else
            {
                Console.WriteLine(customer);
            }
            Console.ReadLine();
        }

        private void DeleteCustomerFromDictionary()
        {
            Console.WriteLine("Slet Customer fra Menuen");
            Console.WriteLine("Indsæt ID");
            string id = Console.ReadLine();
            _customerRepositoryDictionary.DeleteCustomer(id);
        }

        private void UpdateCustomerDictionary()
        {
            Console.WriteLine("Update Customer");
            Console.WriteLine("Indsæt ID");
            string idOld = Console.ReadLine();
            Customer customer = _customerRepositoryDictionary.LookupCustomer(idOld);
            if (customer == null)
            {
                 Console.WriteLine("Customer eksistere ikke");
            }
            else
            {
                 Console.WriteLine("Update Customer");
                 Console.WriteLine("Indsæt ID");
                 string id = Console.ReadLine();
                 Console.WriteLine("Indsæt Name");
                 string name = Console.ReadLine();
                 Console.WriteLine("Indsæt Adresse");
                 string adresse = Console.ReadLine();
                 Console.WriteLine("Indsæt Mobile Nr.");
                 string mobile = Console.ReadLine();

                 Customer updatedCustomer = new Customer(id, name, adresse, mobile);

                 _customerRepositoryDictionary.UpdateCustomer(idOld, updatedCustomer);
                 Console.WriteLine("Customer Updated");
                 Console.ReadLine();

            }
        }
    }
}
