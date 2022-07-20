//creating a path and file name for the file

using System.Text;

string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Example.txt";

//creat file to the path
//-- check if file exists

if (!File.Exists(path))
{
    File.Create(path);
}

//write text to file

//open the file
FileStream fs = File.Open(path, FileMode.Append);

//add the text to the file

byte[] info = new UTF8Encoding(true).GetBytes("Hello World!");

fs.Write(info, 0, info.Length);
fs.Close();

//how to read from a file
StreamReader sr = new StreamReader(path);
string fileText = sr.ReadToEnd();
Console.WriteLine(fileText);

