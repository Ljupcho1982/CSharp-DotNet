
using System.Globalization;
using System.Xml;
// See https://aka.ms/new-console-template for more information

object height = 1.88;
object name = "Amir";
Console.WriteLine($"{name} is {height} meters tall");

//int length1 = name.Length;

int length2=((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

dynamic something = "Ahmet";
something = new[] {88,99,8};


// int doesnt have a lenght property
//and array of any type has a length property
//Console.WriteLine($"Length is: {something.Length}");

// good use of var because it avoids the repeated type
// as shown in the more verbose second statement
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();
// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

Console.WriteLine($"default(int)={default(int)}");
Console.WriteLine($"default(bool)={default(bool)}");
Console.WriteLine($"default(DateTime)={default(DateTime)}");
Console.WriteLine($"default(string)={default(string)}");
string[] array;
array = new string[4];
array[0] = "Ljupcho";
array[1] = "KKK";
array[2] = "KJJ";
array[3] = "KJJ";

for (int i=0; i<array.Length; i++)
{
Console.WriteLine(array[i]);
    

}





