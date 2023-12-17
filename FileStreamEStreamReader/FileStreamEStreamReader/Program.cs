using System.IO;

string path = @"c:\temp\file1.txt";
FileStream fs = null;
StreamReader sr = null;

try
{
    fs = new FileStream(path, FileMode.Open);
    sr = new StreamReader(fs);
    /*poderia ser tmb:
      sr = File.OpenText(path);
     */
    

    while (!sr.EndOfStream) //Para ler todas as linhas de um arquivo
    {
        string line = sr.ReadLine(); //Le apenas 1 linha
        Console.WriteLine(line);
    }
    
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
finally
{
   if (sr != null)
    {
        sr.Close();
    }
    if (fs != null)
    {
        fs.Close();
    }
}