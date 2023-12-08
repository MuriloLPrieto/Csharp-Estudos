using Pedidos.Entities;
using System.Globalization;
using System.Collections.Generic;
using Pedidos.Entities.Enums;

Console.WriteLine("Enter cliente data:");

Console.Write("Name: ");
string nameT = Console.ReadLine();

Console.Write("Email: ");
string emailT = Console.ReadLine();

Console.Write("Birth Date (DD/MM/YYYY): ");
DateTime birthT = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter Order Data: ");

Console.Write("Status: ");
OrderStatus statusT = Enum.Parse<OrderStatus>(Console.ReadLine());

Console.Write("How many item to this order? ");
int n = int.Parse(Console.ReadLine());

Client client = new Client(nameT, emailT, birthT);
DateTime moment = DateTime.Now;

Order order = new Order(moment, statusT, client);

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string pname = Console.ReadLine();
    Console.Write("Product price: ");
    double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(pname, pPrice);
    OrderItem item = new OrderItem(quantity, pPrice, product);
    
    order.AddItem(item);
    
    Console.Clear();
}

Console.WriteLine("Order Sumary:");
Console.WriteLine(order);