//Console.WriteLine(d1);
//Console.WriteLine(d1.Ticks);

using System.Globalization;

DateTime d1 = DateTime.Now;
DateTime d2 = new DateTime(2018, 11, 25);
DateTime d3 = new DateTime(2019, 12, 31, 20, 45, 0);
DateTime d4 = new DateTime(2019, 12, 31, 20, 45, 0, 500);

DateTime d5 = DateTime.Today;
DateTime d6 = DateTime.UtcNow;
DateTime d7 = DateTime.Parse("2001-10-11");
DateTime d8 = DateTime.Parse("2012-12-12 13:05:50");
DateTime d9 = DateTime.Parse("15/07/2000");
DateTime d10 = DateTime.Parse("27-08-1968 15:52:39");
DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d12 = DateTime.ParseExact("07/11/2023 16:50:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);
Console.WriteLine(d6);
Console.WriteLine(d7);
Console.WriteLine(d8);
Console.WriteLine(d9);
Console.WriteLine(d10);
Console.WriteLine(d11);
Console.WriteLine(d12);