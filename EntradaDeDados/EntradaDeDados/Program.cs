string frase = Console.ReadLine(); //Retorna valores na forma de STRING!!1

Console.WriteLine("Voce digitou: " + frase);


string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

Console.WriteLine("Voce digitou: ");
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

string cores = Console.ReadLine();
string[] v = cores.Split(' '); 

//Do jeito que foi colocado aqui, dará erro se digitar apenas um dado e apertar enter!
string a = v[0];
string b = v[1];
string c = v[2];

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);