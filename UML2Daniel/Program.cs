//PizzaRepository - som (List)
//CustomerRepository - som (Dictionary)

using UML2Daniel;

PizzaRepositoryList pizzaRepositoryList = new PizzaRepositoryList();
CustomerRepositoryDictionary customerRepositoryDictionary = new CustomerRepositoryDictionary();

Pizza pizza1 = new Pizza(1, "Tombat", 42, "Tomat");
Pizza pizza2 = new Pizza(2, "OstTo", 65, "Tomat, Ost, Skinke");
pizzaRepositoryList.AddPizza(pizza1);
pizzaRepositoryList.AddPizza(pizza2);
pizzaRepositoryList.PrintPizza(); // Test af Print Pizza
Console.WriteLine("Test af Pizza bliver printet");

Console.WriteLine();
pizzaRepositoryList.DeletePizza(2); 
Console.WriteLine("Pizzaer Efter Slet"); // Test af Delete Pizza
pizzaRepositoryList.PrintPizza();

Console.WriteLine();
Pizza pizza3 = new Pizza(3, "KødDyr", 105, "Skinke, Bacon, Entrecout, Mørbrad");
pizzaRepositoryList.AddPizza(pizza3);
Console.WriteLine("Efter Ny Pizza");
pizzaRepositoryList.PrintPizza();

Console.WriteLine();
Pizza upDatedPizza = new Pizza(3, "Kød Kongen", 110, "Skinke, Bacon, Entrecôte, Mørbrad");
pizzaRepositoryList.UpdatePizza(3, upDatedPizza); // Test af Update Pizza
Console.WriteLine("Opdateret Pizza Navn + Pris");
pizzaRepositoryList.PrintPizza();

Console.WriteLine();
Console.WriteLine("Test af Lookup Pizza"); // Test af Lookup Pizza
Pizza foundPizza = pizzaRepositoryList.LookupPizza(2);
if (foundPizza != null)
{
    Console.WriteLine($"Pizza fundet {foundPizza.ToString()}");
}
else
{
    Console.WriteLine("Pizza ikke fundet");
}

Pizza foundPizza2 = pizzaRepositoryList.LookupPizza(1);
if (foundPizza2 != null)
{
    Console.WriteLine($"Pizza fundet {foundPizza2.ToString()}");
}
else
{
    Console.WriteLine("Pizza ikke fundet");
}

Console.WriteLine();
Console.WriteLine("Test af Dictionary"); // Dictionary Test
Customer newCustomer1 = new Customer("1", "Jens", "Jernvej 11", "12312312");
Customer newCustomer2 = new Customer("2", "Poul", "Jernvej 12", "23423423");
Customer newCustomer3 = new Customer("3", "Jette", "Jernvej 15", "34534534");
customerRepositoryDictionary.AddCustomer(newCustomer1);
customerRepositoryDictionary.AddCustomer(newCustomer2);
customerRepositoryDictionary.AddCustomer(newCustomer3);
customerRepositoryDictionary.PrintCustomer();

Console.WriteLine();
Console.WriteLine("Test af Delete Customer"); //Customer Delete Test
customerRepositoryDictionary.DeleteCustomer("2");
customerRepositoryDictionary.PrintCustomer();

Console.WriteLine();
Console.WriteLine("Test af Update Customer"); //Update Customer Test
Customer upDatedCustomer = new Customer("3", "Sten", "Stenvej 12", "90012312");
customerRepositoryDictionary.UpdateCustomer("3", upDatedCustomer);
customerRepositoryDictionary.PrintCustomer();

Console.WriteLine();
Console.WriteLine("Test af Lookup Customer"); //Lookup Customer Test
customerRepositoryDictionary.LookupCustomer("3");
Customer foundCustomer = customerRepositoryDictionary.LookupCustomer("1");
if (foundCustomer != null)
{
    Console.WriteLine($"Kunde fundet {foundCustomer.ToString()}");
}
else
{
    Console.WriteLine("Kunde ikke fundet");
}

Customer foundCustomer2 = customerRepositoryDictionary.LookupCustomer("2");
if (foundCustomer2 != null)
{
    Console.WriteLine($"Kunde fundet {foundCustomer2.ToString()}");
}
else
{
    Console.WriteLine("Kunde ikke fundet");
}

Menu menu = new Menu(pizzaRepositoryList, customerRepositoryDictionary);
menu.Run();
Console.ReadLine();