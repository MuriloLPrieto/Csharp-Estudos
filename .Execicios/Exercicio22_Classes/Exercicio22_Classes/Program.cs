using Exercicio22_Classes;
using System.Globalization;

Funcionario funcionario = new Funcionario();

Console.WriteLine("Digite Seu Nome:");
funcionario.Nome = Console.ReadLine();
Console.WriteLine("Digite seu salário bruto (Sem descontos):");
funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Digite a quantidade de imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"{funcionario}");

Console.WriteLine("Digite a porcentagem de aumento:");
double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
funcionario.AumentarSalario(aumento);

Console.WriteLine($"{funcionario}");