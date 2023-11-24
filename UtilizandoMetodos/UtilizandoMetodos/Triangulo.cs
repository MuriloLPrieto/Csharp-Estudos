using System;
using System.Globalization;

namespace Classes
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //Criando metodos, obs o metodo precisa ficar dentro da classe

        //No nosso exemplo não será necessario parametros, pois
        //os medotos já estão dentro da classe
        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
