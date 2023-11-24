using System.Globalization;

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine("----------------------------------------");

Console.WriteLine("Digite seu nome, genero, idade e altura");
string[] vet = Console.ReadLine().Split(' ');

string nome = vet[0];
char sex = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(sex);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine();
Console.WriteLine("-------------------------------------------");

Console.WriteLine("Voce digitou: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));