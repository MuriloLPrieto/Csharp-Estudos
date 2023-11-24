using System.Globalization;
using Exercicio21_Classes;

Retangulo retangulo = new Retangulo();

Console.WriteLine("Digite a largura e altura do retângulo: ");
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"{retangulo}");