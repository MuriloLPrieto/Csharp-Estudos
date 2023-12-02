DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);


//Console.WriteLine($"D1: {d1}");
//Console.WriteLine($"D1 Kind: {d1.Kind}");
//Console.WriteLine($"D1 to Local: {d1.ToLocalTime()}");
//Console.WriteLine($"D1 to UTC: {d1.ToUniversalTime()}");

//Console.WriteLine();

//Console.WriteLine($"D2: {d2}");
//Console.WriteLine($"D2 Kind: {d2.Kind}");
//Console.WriteLine($"D2 to Local: {d2.ToLocalTime()}");
//Console.WriteLine($"D2 to UTC: {d2.ToUniversalTime()}");

//Console.WriteLine();

//Console.WriteLine($"D3: {d3}");
//Console.WriteLine($"D3 Kind: {d3.Kind}");
//Console.WriteLine($"D3 to Local: {d3.ToLocalTime()}");
//Console.WriteLine($"D3 to UTC: {d3.ToUniversalTime()}");

DateTime d = DateTime.Parse("2000-08-15 13:05:58");
DateTime d4 = DateTime.Parse("2000-08-15T13:05:58Z");

Console.WriteLine($"D: {d}");
Console.WriteLine($"D2 Kind: {d.Kind}");
Console.WriteLine($"D2 to Local: {d.ToLocalTime()}");
Console.WriteLine($"D2 to UTC: {d.ToUniversalTime()}");

Console.WriteLine();

Console.WriteLine($"D4: {d4}");
Console.WriteLine($"D4 Kind: {d4.Kind}");
Console.WriteLine($"D4 to Local: {d4.ToLocalTime()}");
Console.WriteLine($"D4 to UTC: {d4.ToUniversalTime()}");

Console.WriteLine();

Console.WriteLine(d4.ToString("yyyy-MM-ddTHH:mm:ssZ")); //Cuidado
Console.WriteLine(d4.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));