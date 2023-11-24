using System.Globalization;

string product1 = "Notebook Acer";
string product2 = "Wood Table";

byte age = 20;
int code = 6924;
char gender = 'M';

double price1 = 5300.00;
double price2 = 1750.69;
double medida = 53.234567;

Console.WriteLine("Produtos:");
Console.WriteLine($"{product1} have a price of ${price1}.");
Console.WriteLine($"{product2} have a price of ${price2}");

Console.WriteLine();
Console.WriteLine($"Registro: {age} anos de idade, código {code} e gênero: {gender}");

Console.WriteLine();

Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
Console.WriteLine("Separador decimal invariant culture: " + medida.ToString(CultureInfo.InvariantCulture));