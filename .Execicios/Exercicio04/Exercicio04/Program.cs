Console.WriteLine("CALCULANDO A DIFERENÇA DE 4 NÚMEROS");

Console.WriteLine("Digite o primero número:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o quarto número:");
int d = int.Parse(Console.ReadLine());

int diferenca = a * b - c * d;
Console.WriteLine(diferenca);