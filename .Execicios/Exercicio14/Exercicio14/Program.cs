using System.Globalization;

Console.WriteLine("Digite 2 numeros");
string[] numeros = Console.ReadLine().Split();

double x = double.Parse(numeros[0], CultureInfo.InvariantCulture);
double y = double.Parse(numeros[1], CultureInfo.InvariantCulture);

if (x == 0 && y == 0)
{
    Console.WriteLine("Origem");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Quadrante 1");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Quadrante 2");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Quadrante 3");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Quadrante 4");
}
else if (x == 0 && y != 0)
{
    Console.WriteLine("Eixo Y");
}
else if (x != 0 && y == 0)
{
    Console.WriteLine("Eixo X");
}
else
{
    Console.WriteLine("Erro");
}