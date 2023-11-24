using System.Numerics;

Console.WriteLine("Bem vindo a nossa lanchonete, escolha um produto pelo codigo");
Console.WriteLine("1 - Cachorro Quente R$4,00");
Console.WriteLine("2 - X-Salada R$4.50");
Console.WriteLine("3 - X-Bacon R$5,00");
Console.WriteLine("4 - Torrada Simples R$2,00");
Console.WriteLine("5 - Refrigerante R$1,50");
Console.WriteLine();
int opc = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Digite a quantidade");
int quant = int.Parse(Console.ReadLine());

double total = 0;

switch (opc)
{
    case 1:
        total = 4.0 * quant;
        break;
    case 2:
        total = 4.5 * quant;
        break;
    case 3:
        total = 5.0 * quant;
        break;
    case 4:
        total = 2.0 * quant;
        break;
    case 5:
        total = 1.5 * quant;
        break;
    default:
        Console.WriteLine("Erro");
        break;
}
Console.WriteLine($"Total: R${total:F2}");