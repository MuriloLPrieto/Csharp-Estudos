using System.Globalization;

double xA, xB, xC;
double yA, yB, yC;

Console.WriteLine("Digite as medidas do triângulo X:");
string[] triX = Console.ReadLine().Split(' ');
xA = double.Parse(triX[0], CultureInfo.InvariantCulture);
xB = double.Parse(triX[1], CultureInfo.InvariantCulture);
xC = double.Parse(triX[2], CultureInfo.InvariantCulture);

Console.WriteLine("Digite as medidas do triângulo y");
yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC) / 2.0;
double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

p = (yA + yB + yC) / 2.0;
double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

Console.WriteLine($"Área do triângulo X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Área do triângulo Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

if (areaX > areaY)
{
    Console.WriteLine("Triângulo X maior");
}
else if (areaX < areaY)
{
    Console.WriteLine("Triângulo Y maior");
} else
{
    Console.WriteLine("Tamanhos iguais");
}