using Exercicio19_Classes;

Pessoa pessoa1, pessoa2;

pessoa1 = new Pessoa();
pessoa2 = new Pessoa();

Console.WriteLine("Digite um nome: ");
pessoa1.Nome = Console.ReadLine();
Console.WriteLine("Digite sua idade: ");
pessoa1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um segundo nome: ");
pessoa2.Nome = Console.ReadLine();
Console.WriteLine("Digite sua idade: ");
pessoa2.Idade = int.Parse(Console.ReadLine());

if (pessoa1.Idade > pessoa2.Idade)
{
    Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");
}
else if (pessoa2.Idade > pessoa1.Idade)
{
    Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
}
else
{
    Console.WriteLine($"Os dois tem {pessoa1.Idade} anos");
}