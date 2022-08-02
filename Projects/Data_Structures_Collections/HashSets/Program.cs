using System.Collections.Generic;

HashSet<string> letters1 = new HashSet<string>() { "a", "b", "c" };
HashSet<string> letters2 = new HashSet<string>() { "d", "e", "e","a","b" };
//letters1.UnionWith(letters2);
//foreach(string s in letters1)
//{
//    Console.WriteLine(s);
//}

Console.WriteLine("-------------------------------------------");
//letters1.IntersectWith(letters2);

//foreach(string s in letters1)
//{
//    Console.WriteLine(s);
//}

//Console.WriteLine("-------------------------------------------");

//letters1.ExceptWith(letters2);

//foreach (string s in letters1)
//{
//    Console.WriteLine(s);
//}


letters1.SymmetricExceptWith(letters2);

foreach (string s in letters1)
{
    Console.WriteLine(s);
}