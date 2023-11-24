using System.Globalization;

Console.WriteLine("Digite 2 cordenadas");
string[] cordenadas = Console.ReadLine().Split(' ');

double x = double.Parse(cordenadas[0]);
double y = double.Parse(cordenadas[1]);

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Primeiro");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Segundo");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Terceiro");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Quarto");
    }
    cordenadas = Console.ReadLine().Split(' ');
    x = double.Parse(cordenadas[0]);
    y = double.Parse(cordenadas[1]);
}
Console.WriteLine("Terminou");