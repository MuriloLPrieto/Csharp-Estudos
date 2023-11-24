using Properties;
using System.Globalization;

Produtos p = new Produtos("TV", 500.00, 10);

Console.WriteLine(p.Nome);

p.Nome = "T";

Console.WriteLine(p.Nome);
Console.WriteLine(p.Preco);
Console.WriteLine(p.Quantidade);