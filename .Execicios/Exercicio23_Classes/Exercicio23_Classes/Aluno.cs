using System;
using System.Globalization;

namespace Exercicio23_Classes
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public void Verificador()
        {
            double notaFinal = Nota1 + Nota2 + Nota3;
            if (notaFinal >= 60 )
            {
                Console.WriteLine($"Nota Final: {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine($"Nota Final: {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO!");
                double reprovado = 60.0 - notaFinal;
                Console.WriteLine($"FALTARAM {reprovado.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
