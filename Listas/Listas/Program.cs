using System;
using System.Collections.Generic; //Para poder utilizar Listas

//List<string> list = new List<string>(); //Criando lista vazia

//List<string> list2 = new List<string> { "Maria", "Alex" }; //Criando lista com dados

List<string> lista = new List<string>();

lista.Add("Murilo");
lista.Add("Alex"); //O add adiciona no final da lista!
lista.Add("Alana");
lista.Add("Julia");

lista.Insert(1, "Leonardo"); //Adicionar em uma posição especifica

foreach (string obj in lista)
{
    Console.WriteLine(obj);
}

Console.WriteLine("---------------------------------------------------------------");

Console.WriteLine($"Número de itens na lista: {lista.Count}");

string s1 = lista.Find(x => x[0] == 'A'); //O find recebe uma função que realiza um teste logico
//O find() busca o primeiro
string s2 = lista.FindLast(x => x[0] == 'A');//Acha o ultimo

int pos1 = lista.FindIndex(x => x[0] == 'A');
int pos2 = lista.FindLastIndex(x => x[0] == 'A');

Console.WriteLine($"Primeiro nome com A: {s1}");
Console.WriteLine($"Posição do primeiro A: {pos1}");

Console.WriteLine($"Ultimo nome com A: {s2}");
Console.WriteLine($"Posição do ultimo A: {pos2}");

List<string> res = lista.FindAll(x => x.Length == 5); //Filtrando para mostrar apenas nomes com 5 caracteres

Console.WriteLine("------------------------------------------------------------");
foreach (string s in res)
{
    Console.WriteLine(s);
}

Console.WriteLine("------------------------------------------------------------");

lista.Remove("Alex");

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------------------------------------------");
lista.RemoveAll(x=> x[0] == 'L');

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------------------------------------------");
lista.RemoveAt(1);
foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------------------------------------------");
lista.Add("Alex");
lista.Add("Alana");

lista.RemoveRange(2, 2);

foreach (string n in lista)
{
    Console.WriteLine(n);
}

/*static bool Teste(string s)
{
    return s[0] == 'A'; Podemos passar essa função Teste como parametro no find.
}*/