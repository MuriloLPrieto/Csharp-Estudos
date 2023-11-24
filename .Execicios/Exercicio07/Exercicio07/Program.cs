using System.Globalization;

Console.WriteLine("Digite três valores: ");
string[] valores = Console.ReadLine().Split();
double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture),
    n2 = double.Parse(valores[1], CultureInfo.InvariantCulture),
    n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

double areaTriang = n1 * n3 / 2;
double areaCirc = 3.14159 * Math.Pow(n3, 2);
double areaTrap = ((n1 + n2) * n3) / 2;
double areaQuad = Math.Pow(n2, 2);
double areaRetang = n1 * n2;

Console.WriteLine($"A área do triângulo é: {areaTriang.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"A área do círculo é: {areaCirc.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"A área do trapézio é: {areaTrap.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"A área do quadrado é: {areaQuad.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"A área do retângulo é: {areaRetang.ToString("F3", CultureInfo.InvariantCulture)}");