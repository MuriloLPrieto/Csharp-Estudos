using System;
using System.Globalization;
namespace Exercicio21_Classes
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        double Area() 
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return "Area: " + Area().ToString("F2", CultureInfo.InvariantCulture) + 
                ", Perimetro: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) +
                ", Diagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
        double Perimetro() 
        {
            return 2 *(Altura + Largura);
        }
        double Diagonal() 
        {
            double diagonal = Math.Pow(Altura, 2) + Math.Pow(Largura, 2) ;
            return Math.Sqrt(diagonal);
        }
    }
}
