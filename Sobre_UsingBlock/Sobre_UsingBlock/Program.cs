using System.IO;

string path = @"c:\temp\file1.txt";
try
{
    //using (FileStream fs = new FileStream(path, FileMode.Open))
    //{
    //    using (StreamReader sr = new StreamReader(fs))
    //    {
    //        while (!sr.EndOfStream)
    //        {
    //            string line = sr.ReadLine();
    //            Console.WriteLine(line);
    //        }
    //    }
    // Forma não resumida
    //}

    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
    //Forma resumida
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}