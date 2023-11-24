using System.Globalization;
Console.WriteLine("Digite um número entre 0 a 100");
double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (num >= 0 && num <= 25)
{
    Console.WriteLine("Número entre 0 e 25");
}else if (num > 25 && num <= 50)
{
    Console.WriteLine("Número entre 25 e 50");
}else if (num > 50 && num <= 75)
{
    Console.WriteLine("Número entre 50 e 75");
}
else if (num > 75 && num <= 100)
{
    Console.WriteLine("Número entre 75 e 100");
}
else
{
    Console.WriteLine("Numero invalido");
}