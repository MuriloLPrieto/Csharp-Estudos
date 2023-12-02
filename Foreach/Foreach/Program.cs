string[] vetor = new string[] { "Maria", "Bob", "Narcisus"};

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"For: {vetor[i]}");
}

Console.WriteLine("---------------------------------------------------------------------");

//tipo do vetor, apelido, in, nome do vetor
foreach(string nome in vetor)
{
    Console.WriteLine($"Foreach: {nome}");
}