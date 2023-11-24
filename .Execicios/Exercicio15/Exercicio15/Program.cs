using System.ComponentModel.Design;
using System.Globalization;

namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu sálario:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto = 0.0;

            if (salario <=2000)
            {
                imposto = 0.0;
            }
            else if(salario <= 3000)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500)
            {
                imposto = (salario - 3000.0) * 0.18 + (1000.0 * 0.08) ;
            }
            else if (salario > 4500)
            {
                imposto = (salario - 3000.0) * 0.28 + (1500.0 * 0.18) + (1000.0 * 0.08);
            }
            else
            {
                Console.WriteLine("Erro");
            }
            Console.WriteLine($"O valor a ser pago de imposto é: R${imposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
