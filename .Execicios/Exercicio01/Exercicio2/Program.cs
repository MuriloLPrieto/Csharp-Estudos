using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Nome Completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu peso:");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu sobrenome, gênero (M para masculino, F para feminino e O para outros), idade e altura (tudo na mesmo linha!):");
            string[] dados = Console.ReadLine().Split(' ');

            string sobrenome = dados[0];
            char genero = char.Parse(dados[1].ToLower());
            int idade = int.Parse(dados[2]);
            double altura = double.Parse(dados[3], CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Dados recebidos:");
            
            Console.WriteLine($"Nome completo: {nome}");
            Console.WriteLine($"Sua casa possui {quartos} quartos");
            Console.WriteLine($"Você pesa: {peso.ToString("F2", CultureInfo.InvariantCulture)}Kg");
            Console.WriteLine($"Seu sobrenome é: {sobrenome}");
            if(genero == 'm')
            {
                Console.WriteLine("Você é: Homem");
            }else if (genero == 'f')
            {
                Console.WriteLine("Você é: Mulher");
            }
            else if(genero == 'o')
            {
                Console.WriteLine("Você é: GAY");
            }
            else
            {
                Console.WriteLine("Gênero invalido");
            }
            Console.WriteLine($"Você tem {idade} anos");
            Console.WriteLine($"Sua altura é: {altura.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("------------------------------");
        }
    }
}
