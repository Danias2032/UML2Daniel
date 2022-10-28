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

pizzaRepositoryList.DeletePizza(2); 
Console.WriteLine("Pizzaer Efter Slet"); // Test af Delete Pizza
pizzaRepositoryList.PrintPizza();
Pizza pizza3 = new Pizza(3, "KødDyr", 105, "Skinke, Bacon, Entrecout, Mørbrad");
pizzaRepositoryList.AddPizza(pizza3);
Console.WriteLine("Efter Ny Pizza");
pizzaRepositoryList.PrintPizza();

Pizza upDatedPizza = new Pizza(3, "Kød Kongen", 110, "Skinke, Bacon, Entrecôte, Mørbrad");
pizzaRepositoryList.UpdatePizza(3, upDatedPizza); // Test af Update Pizza
Console.WriteLine("Opdateret Pizza Navn + Pris");
pizzaRepositoryList.PrintPizza();

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

