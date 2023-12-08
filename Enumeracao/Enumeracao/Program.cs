using Enumeracao.Entities;
using Enumeracao.Entities.Enums;

Order order = new Order { 
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

string txt = OrderStatus.PendingPayment.ToString();
Console.WriteLine(txt);
Console.WriteLine(os);