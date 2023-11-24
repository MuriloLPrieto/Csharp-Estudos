using Exercicio20_Classes;
using System.Globalization;

Funcionario funcionario1, funcionario2;

funcionario1 = new Funcionario();
funcionario2 = new Funcionario();

Console.WriteLine("Nome do primeiro funcionario:");
funcionario1.Name = Console.ReadLine();
string[] fName = funcionario1.Name.Split(' ');
Console.WriteLine($"{fName[0]} informe seu salário: ");
funcionario1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Nome do segundo funcionario:");
funcionario2.Name = Console.ReadLine();
fName = funcionario2.Name.Split(' ');
Console.WriteLine($"{fName[0]} informe seu salário: ");
funcionario2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double medSal =  (funcionario1.Salary + funcionario2.Salary) / 2;

Console.WriteLine($"Média salárial: R${medSal.ToString("f2", CultureInfo.InvariantCulture)}");

if (funcionario1.Salary > funcionario2.Salary)
{
    Console.WriteLine($"Funcionario {funcionario1.Name} possui o maior salário.");
}
else if (funcionario1.Salary < funcionario2.Salary)
{
    Console.WriteLine($"Funcionario {funcionario2.Name} possui o maior salário.");
}
else
{
    Console.WriteLine($"Os dois possuem salário iguais.");
}