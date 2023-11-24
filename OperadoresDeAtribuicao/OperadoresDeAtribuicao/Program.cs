using System.Globalization;
using System.Threading.Tasks.Dataflow;

int a = 10;
Console.WriteLine(a);

a += 2;

Console.WriteLine(a);

a *= 3;
Console.WriteLine(a);

int b = 10;
b++;
Console.WriteLine(b);
b--;
Console.WriteLine(b);

int c = ++b; 
/*
    int c = b++; -> Primeiro ele passa o valor de b para a variavel c e logo em seguida ele acrescenta 1 no valor da variavel b
    int c = ++b; -> Primeiro ele acrescenta 1 no valor de b e logo em seguida passa o valor de b para a variavel c
*/
Console.WriteLine(c);
Console.WriteLine(b);

string s = "ABC";
Console.WriteLine(s);
s += "DEF";
Console.WriteLine(s);