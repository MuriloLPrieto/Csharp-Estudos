Console.Write("Digite o tamanho da coluna: ");
string[] tamanho = Console.ReadLine().Split(' ');
int m = int.Parse(tamanho[0]);
int n = int.Parse(tamanho[1]);

int[,] mat = new int[m, n];

for (int i = 0; i < m; i++)
{
    Console.WriteLine("Digite os números: ");
    string[] temp = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(temp[j]);
    }
}

Console.WriteLine();
Console.Write("Digite o número que deseja localizar: ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i,j] == x)
        {
            Console.WriteLine("Posição: " + i + ", " + j);
            if (j > 0)
            {
                Console.WriteLine($"Esquerda: {mat[i, j -1]}");
            }
            if (i > 0)
            {
                Console.WriteLine($"Cima: {mat[i -1, j]}");
            }
            if (j < n - 1)
            {
                Console.WriteLine($"Direita: {mat[i, j +1]}");
            }
            if (i < m - 1)
            {
                Console.WriteLine($"Baixo: {mat[i + 1, j]}");
            }
            Console.WriteLine();
        }
    }
}