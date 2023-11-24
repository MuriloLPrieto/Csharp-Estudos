using MembrosEstaticos;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Quando definido membros estáticos dentro de uma classe, não é necessário instanciar um objeto,
        pois quando o membro é estático sempre retornara um valor apenas. 
        Diferente do exemplo dos triângulos onde tínhamos 2 triângulos diferente com valores diferentes, aqui apenas possuímos 1 objeto. 
        */

            Console.WriteLine("Entre o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.CalcularCirc(raio);
            double volume = Calculadora.CalcularVol(raio);

            Console.WriteLine(circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}