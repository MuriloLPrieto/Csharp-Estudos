//Vetores armazenando objetos do tipo classe

using System.Globalization;
using System.Net.Http.Headers;
using Vetores2;

Console.WriteLine("Digite o número de produtos a serem registrados: ");
int nProdutos = int.Parse(Console.ReadLine());

Product[] products = new Product[nProdutos];

for (int i = 0; i < nProdutos; i++)
{
    Console.WriteLine();

    Console.WriteLine("Digite o nome e preço do produto: ");

    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    products[i] = new Product { Name = name, Price = price }; //pode ser feito com construtores
    
    Console.WriteLine();
}

double soma = 0.0;

for (int i = 0;i < nProdutos; i++)
{
    soma += products[i].Price;
}

double avg = soma / nProdutos;

Console.WriteLine($"Preço medio = R${avg.ToString("F2", CultureInfo.InvariantCulture)}");