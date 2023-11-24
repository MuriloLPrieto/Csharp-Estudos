using System.Globalization;

namespace MembrosEstaticos
{
    internal class Calculadora
    {
        public static double Pi = 3.14;

        public static double CalcularVol(double r)
        {
            return 4.0 / 3 * Pi * Math.Pow(r, 3);
        }

        public static double CalcularCirc(double r)
        {
            return 2.0 * Pi * r;
        }
    }
}
