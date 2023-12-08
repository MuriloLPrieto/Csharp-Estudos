//Exercicio Seção 10: Herança e polimorfismo, aula 140/141
using System.Globalization;
using ExercicioFuncionarios.Entities;

List<Employer> employers = new List<Employer>();

Console.WriteLine("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data: ");
    Console.Write("Outsourced (y/n)? ");
    string selection = Console.ReadLine().ToLower();

    Console.Write("Name: ");
    string nameT = Console.ReadLine();
    Console.Write("Hours: ");
    int hoursT = int.Parse(Console.ReadLine());
    Console.Write("Value per Hour: ");
    double valueT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (selection == "y")
    {
        Console.Write("Adicional charge: ");
        double charging = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        employers.Add(new OutSourcedEmployee(nameT, hoursT, valueT, charging));
    }
    else
    {
        employers.Add(new Employer(nameT, hoursT, valueT));
    }
    Console.Clear();
}

Console.WriteLine("Payments: ");
foreach (Employer employee in employers)
{
    Console.WriteLine(employee);
}