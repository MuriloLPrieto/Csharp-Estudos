Console.Write("Numero matriz: ");
int tamanho = int.Parse(Console.ReadLine());

int[,] mat = new int[tamanho, tamanho];

for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine("Digite os numeros: ");
    string[] valores = Console.ReadLine().Split(' ');

    for (int j = 0; j < tamanho; j++)
    {
        mat[i, j] = int.Parse(valores[j]);
    }
}

Console.WriteLine();

Console.WriteLine("Diagonal principal: ");
for (int i = 0;i < tamanho; i++)
{
    Console.Write($"{ mat[i, i]} ");
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < tamanho; i++)
{
    for (int j = 0; j < tamanho; j++)
    {
        if (mat[i,j] < 0)
        {
            count++;
        }
    }
}

Console.WriteLine($"Quantidade de negativos: {count}");