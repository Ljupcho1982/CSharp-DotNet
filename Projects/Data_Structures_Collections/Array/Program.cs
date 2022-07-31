using System.Diagnostics;

/// <summary>
/// There four ways to create an Array
/// </summary>
/// 
///First way
string[] strings = new string[3];

strings[0] = "a";
strings[1] = "b";
strings[2] = "c";

//second way




string[] string1 = new string[3] { "a", "b", "c" };

//third way

string[] string2 = new string[] { "a", "b", "c" };

//fourth ways

string[] string3 = { "a", "b", "c" };

int[] array = new int[3] { 1, 2, 3 };

Console.WriteLine(array[0]);
Console.WriteLine(array.Length);

array[0] = 5;

Array.Sort(array);

foreach(int i in array)
{

    Console.WriteLine(i);
}

string[] array1 = new string[] { "c", "a", "d" };

Array.Sort(array1);

foreach(string s in array1)
{

    Console.WriteLine(s);
}

