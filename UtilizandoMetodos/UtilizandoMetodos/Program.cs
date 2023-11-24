using Classes;
using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Digite as medidas do triângulo X:");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite as medidas do triângulo y");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.CalcularArea(); //Chamando metodos
double areaY = y.CalcularArea();

Console.WriteLine($"Área do triângulo X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Área do triângulo Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

if (areaX > areaY)
{
    Console.WriteLine("Triângulo X maior");
}
else if (areaX < areaY)
{
    Console.WriteLine("Triângulo Y maior");
}
else
{
    Console.WriteLine("Tamanhos iguais");
}