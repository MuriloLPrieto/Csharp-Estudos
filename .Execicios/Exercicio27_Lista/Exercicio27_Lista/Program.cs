using System.Collections.Generic;
using System.Globalization;
using Exercicio27_Lista;

Console.Write("Quantos funcionarios serão registrados? ");
int n = int.Parse(Console.ReadLine());

List<Funcionarios> lista = new List<Funcionarios>();

for (int i = 1; i <= n ; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Funcionario #{i}");
    Console.Write("Id: ");
    int idAux = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nomeAux = Console.ReadLine();
    Console.Write("Salario: ");
    double salarioAux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    lista.Add(new Funcionarios(idAux, nomeAux, salarioAux));
}

Console.WriteLine();

Console.Write("Digite o Id do funcionario que receberá aumento: ");
int auxId =  int.Parse(Console.ReadLine());
Funcionarios f = lista.Find(x => x.Id == auxId);
Console.WriteLine();

while (true)
{
    if (f != null)
    {
        Console.WriteLine("Digite a porcentagem do aumento: ");
        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        f.AumentaSalario(porcentagem);
        break;
    }
    else
    {
        Console.WriteLine("ID Invalido!");
        Console.Write("Digite o Id do funcionario que receberá aumento: ");
        auxId = int.Parse(Console.ReadLine());
        Funcionarios x = lista.Find(x => x.Id == auxId);
        f = x;
    } 
}

Console.WriteLine();

foreach (Funcionarios aux in lista)
{
    Console.WriteLine(aux);
}