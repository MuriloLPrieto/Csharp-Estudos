using System.IO;

string sourcePath = @"c:\temp\file1.txt";
string targetPath = @"c:\temp\file2.txt";

try
{
    FileInfo fileinfo = new FileInfo(sourcePath);
    //fileinfo.CopyTo(targetPath);

    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string item in lines)
    {
        Console.WriteLine(item);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occured: " + e.Message);
}