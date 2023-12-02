using System;
using System.Globalization;

namespace Ref_Out
{
    internal class Calculadora
    {
        public static void Triple(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
