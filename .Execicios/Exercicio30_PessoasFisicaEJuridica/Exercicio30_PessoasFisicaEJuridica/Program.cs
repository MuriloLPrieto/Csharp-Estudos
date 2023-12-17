using Exercicio30_PessoasFisicaEJuridica.Entities;
using System.Globalization;

List<Pessoa> list = new List<Pessoa>();

Console.Write("Entre com o numero de pagadores: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Pagador #{i}:");
    Console.Write("Pessoa Fisica ou Juridica (f/j)? ");
    char opcao = char.Parse(Console.ReadLine().ToLower());
    Console.Write("Nome: ");
    string name = Console.ReadLine();
    Console.Write("Renda anual: ");
    double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (opcao == 'f')
    {
        Console.Write("Gastos Medicos: ");
        double gastos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Fisica(name, renda, gastos));
    }
    else if (opcao == 'j')
    {
        Console.Write("Número de Funcionarios: ");
        int funcionarios = int.Parse(Console.ReadLine());

        list.Add(new Juridica(name, renda, funcionarios));
    }
    else
    {
        Console.WriteLine("ERROR!");
    }

    Console.Clear();
}

double totalImposto = 0;

Console.WriteLine("Taxes Paid: ");
foreach (Pessoa taxa in list)
{
    Console.WriteLine($"{taxa.Name}: R${taxa.Impostos().ToString("f2", CultureInfo.InvariantCulture)}");
    totalImposto += taxa.Impostos();
}

Console.WriteLine();
Console.WriteLine($"Total pago em impostos: R${totalImposto.ToString("F2", CultureInfo.InvariantCulture)}");