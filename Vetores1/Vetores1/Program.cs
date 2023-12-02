using System.Globalization;

Console.WriteLine("Digite o número de pessoas: ");
int npessoas = int.Parse(Console.ReadLine());

double[] vetor = new double[npessoas];

Console.WriteLine($"Digite a altura das {npessoas} pessoas: ");

for (int i = 0; i < npessoas; i++)
{
    vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double soma = 0.0;

for (int i = 0;i < npessoas; i++)
{
    soma += vetor[i];
}

double media = soma / npessoas;

Console.WriteLine($"Altura média {media.ToString("F2", CultureInfo.InvariantCulture)}");