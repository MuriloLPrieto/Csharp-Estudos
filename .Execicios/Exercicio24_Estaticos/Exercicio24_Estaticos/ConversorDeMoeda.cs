using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24_Estaticos
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Converter(double cotacao, double valor)
        {
            double precoTotal = cotacao * valor;

            return precoTotal + precoTotal * Iof/100.0;
        }

    }
}
