Console.WriteLine("Digita 2 número ai rapidão:");
string[] numeros = Console.ReadLine().Split(' ');

int n1 = int.Parse(numeros[0]);
int n2 = int.Parse(numeros[1]);

if  (n1 % n2 == 0 || n2 % n1 == 0)
{
    Console.WriteLine("São multiplos");
}
else
{
    Console.WriteLine("Não são multiplos");
}
