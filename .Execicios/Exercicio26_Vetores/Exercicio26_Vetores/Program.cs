using Exercicio26_Vetores;
using System.Numerics;

Estudante[] vetor = new Estudante[10];

Console.Write("Digite quantos quartos serão alugados: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Quarto #{i}");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());

    vetor[quarto] = new Estudante(nome, email);
}

Console.WriteLine();
Console.WriteLine("Quartos alugados: ");
for (int i = 0; i < 10; i++)
{
    if (vetor[i] != null)
    {
        Console.WriteLine($"{i}: {vetor[i]}");
    }
}
