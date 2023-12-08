using System.Globalization;
using System.Collections.Generic;
using Exercicio29_HerancaEPolimorfismo.Entities;
using System.Diagnostics;

List<Product> list = new List<Product>();

Console.WriteLine("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");

    char option = char.Parse(Console.ReadLine().ToString().ToLower()) ;

    if (option != 'i'  && option != 'u'  && option != 'c' )
    {
        Console.WriteLine("Invalid Option!");
        Console.WriteLine("Your product will be considered as common! ");
        option = 'c';
    }

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (option == 'c')
    {
        list.Add(new Product(name, price));
    }
    else if (option == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime data = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, data));

    }
    else if (option == 'i')
    {
        Console.Write("Customs fee: ");
        double custom = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new ImportedProduct(name, price, custom));
    }

    Console.Clear();
}

Console.WriteLine("PRICE TAGS: ");

foreach (Product p in list)
{
    Console.WriteLine(p.PriceTag());
}