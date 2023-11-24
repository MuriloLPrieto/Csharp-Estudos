namespace Funcoes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3); //Chamando a função
            Console.WriteLine($"Maior = {resultado}");
        
        }
        //Declarar funções é sempre fora do escopo Main
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}

/* Assim que se declara função em instrução de alto-nível no c#
 
Console.WriteLine("Digite 3 números");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

double resultado = Maior(n1, n2, n3);
Console.WriteLine($"Maior = {resultado}");


int Maior(int a, int b, int c)
{
    int m;
    if (a > b && a > c)
    {
        m = a;
    }
    else if (b > c)
    {
        m = b;
    }
    else
    {
        m = c;
    }
    return m;
}

*/