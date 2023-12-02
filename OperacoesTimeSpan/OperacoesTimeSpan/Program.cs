namespace OperacoesTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            //Console.WriteLine(t);

            //Console.WriteLine($"Days: {t.Days}");
            //Console.WriteLine($"Hours: {t.Hours}");
            //Console.WriteLine($"Minutes: {t.Minutes}");
            //Console.WriteLine($"Seconds: {t.Seconds}");
            //Console.WriteLine($"Miliseconds: {t.Milliseconds}");
            //Console.WriteLine($"Ticks: {t.Ticks}");

            //Console.WriteLine("--------------------------------------------------------");

            //Console.WriteLine($"Total Days: {t.TotalDays}");
            //Console.WriteLine($"Total Hours: {t.TotalHours}");
            //Console.WriteLine($"Total Minutes: {t.TotalMinutes}");
            //Console.WriteLine($"Total Seconds: {t.TotalSeconds}");
            //Console.WriteLine($"Total Miliseconds: {t.TotalMilliseconds}");

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan Soma = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2);
            TimeSpan div = t2.Divide(2);

            Console.WriteLine(Soma);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
