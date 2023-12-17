using System.IO;
using System.Collections.Generic;

string caminho = @"c:\temp\myfolder";

try
{
    //Pegando pastas
    IEnumerable<string> folders = Directory.EnumerateDirectories(caminho, "*.*", SearchOption.AllDirectories);
    //o "*.*" pega todos os arquivos independente de extensão. O SearchOption.AllDirectories mostra arquivos dentro de subpastas
    Console.WriteLine("Folders:");
    foreach(string f in folders)
    {
        Console.WriteLine(f);
    }

    Console.WriteLine();

    //Mostrando arquivos na pasta

    IEnumerable<string> files = Directory.EnumerateFiles(caminho, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Files:");
    foreach(string file in files)
    {
        Console.WriteLine(file);
    }

    //Criando uma pasta
    //Directory.CreateDirectory(caminho + @"\NewFolder"); ou:
    Directory.CreateDirectory("c:\\temp\\myfolder\\newFolder"); //São dois \ pois não foi usado o @ no inicio do caminho
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}