using System.Collections.Generic;


Dictionary<string, string> dictionary = new Dictionary<string, string>();

dictionary.Add("key1", "value1");

dictionary.Add("key2", "value1");
dictionary.Add("key3", "value3");
foreach (string key in dictionary.Keys)
{

    Console.WriteLine(key);
}

foreach(string value in dictionary.Values)
{

    Console.WriteLine(value);
}

if (!dictionary.ContainsKey("key1"))
{

    dictionary.Add("key1","value1")
}
else
{
    Console.WriteLine("key1 exists");
}

if (dictionary.ContainsKey("key3"))
{

    Console.WriteLine(dictionary["key3"]);
};

string value = "";

dictionary.TryGetValue("key1", out value);
