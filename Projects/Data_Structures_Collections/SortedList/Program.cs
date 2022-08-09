using System.Collections.Generic;

SortedList<string, int> sortedList = new SortedList<string, int>() { { "key1", 1 }, { "key2", 2 }, { "key3", 3 } };
sortedList.Capacity = 6;

Console.WriteLine("the sortedList capacity is: " + sortedList.Capacity);
Console.WriteLine("the sortedList count is: " + sortedList.Count);

foreach(string key in sortedList.Keys)
{

    Console.WriteLine(key);
}

foreach(int value in sortedList.Values)
{

    Console.WriteLine(value);
}

sortedList.Add("key4", 4);
