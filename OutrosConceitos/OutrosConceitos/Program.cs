using System.Globalization;

namespace OutrosConceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.Clear();

            Console.WriteLine("Número: ");
            int n = int.Parse(Console.ReadLine());

            string day;

            switch (n)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid Value!!";
                    break;
            }
            Console.WriteLine(day);

            //Condição ternaria

            Console.WriteLine("Preco:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
