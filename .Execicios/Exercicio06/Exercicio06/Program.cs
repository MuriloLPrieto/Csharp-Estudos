using System.Globalization;

Console.WriteLine("Digite o codigo da peça 1, a quantidade e o valor unitário: ");
string[] peca1 = Console.ReadLine().Split(' ');

int codPeca1 = int.Parse(peca1[0]);
int quantPeca1 = int.Parse(peca1[1]);
double valorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

Console.WriteLine("Digite o codigo da peça 2, a quantidade e o valor unitário: ");
string[] peca2 = Console.ReadLine().Split(' ');

int codPeca2 = int.Parse(peca2[0]);
int quantPeca2 = int.Parse(peca2[1]);
double valorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

double valorFinal = (valorPeca1 * quantPeca1) + (valorPeca2 * quantPeca2);
Console.WriteLine($"O valor total ficou: R${valorFinal.ToString("F2", CultureInfo.InvariantCulture)}");