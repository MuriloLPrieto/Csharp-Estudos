using System.IO;
using System.Collections.Frozen;

FileStream fs = null;

try
{
    fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
    StreamReader sr = new StreamReader(fs);
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
catch (Exception e)
{
    Console.WriteLine("Erro: " + e.Message);
}
finally{
    if (fs != null)
    {
        fs.Close();
    }
}