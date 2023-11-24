using System.Globalization;

Console.WriteLine("Digite o valor do raio da circunferência:");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = 3.14159 * Math.Pow(raio, 2);

Console.WriteLine($"A area da circunferencia é : {area.ToString("F4", CultureInfo.InvariantCulture)} ");