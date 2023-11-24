using System;
using System.Globalization;

namespace Exercicio22_Classes
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
    
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcento)
        {
            SalarioBruto += SalarioBruto * (porcento/100);
        }

        public override string ToString()
        {
            return $"Funcionario {Nome}, R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}" ;
        }
    }
}
