using Encapsulamento;
using System.Globalization;

Produto p = new Produto("TV", 500.00, 10);

Console.WriteLine(p.GetNome());

p.SetNome("TV Samsung 4K");

Console.WriteLine(p.GetNome());
Console.WriteLine(p.GetPreco());
Console.WriteLine(p.GetQuantidade());

p.ValorTotalEstoque();
p.AdicionarProdutos(5);
Console.WriteLine(p.GetQuantidade());