using Classes;
using System.Globalization;

Triangulo x, y; //Declarando variaveis do tipo Class

x = new Triangulo();
y = new Triangulo();

//Para armazenar os dados nas variaveis com classe:
Console.WriteLine("Digite as medidas do triângulo X:");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

/*x.A significa que na variavel x que foi declarada no inicio,
vai receber um valor que será guardado no atributo A declarado
na classe. x.A é resumidamente variavel x.atribulto A.
*/

Console.WriteLine("Digite as medidas do triângulo y");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (x.A + x.B + x.C) / 2.0;
double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

p = (y.A + y.B + y.C) / 2.0;
double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

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