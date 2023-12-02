using System.Globalization;

namespace Exercicio24_Estaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação do dolar:");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser comprado: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago: " + ConversorDeMoeda.Converter(cotacao, valor).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
