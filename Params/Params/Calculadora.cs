using System;
using System.Globalization;

namespace Params
{
    internal class Calculadora
    {
        public static int Soma(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
