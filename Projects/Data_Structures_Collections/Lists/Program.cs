using System.Collections.Generic;


  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };


numbers.Capacity = 10;
numbers.Add(6);
List<int> subList = new List<int>() { 7, 8 };
numbers.AddRange(subList);
numbers.Sort();
Console.WriteLine("index of element 5 is: " + numbers.BinarySearch(5));
Console.WriteLine(numbers.Contains(3));
Console.WriteLine(numbers.Contains(20));
numbers.Insert(0, 9);



List<int> sublist1 = new List<int>() { 5, 9, 8 };

numbers.InsertRange(0, sublist1);

numbers.Remove(3);
numbers.RemoveAt(0);
numbers.RemoveRange(0, 3);

numbers.Capacity = 10;
Console.WriteLine("Capacity before trim: " + numbers.Capacity);
numbers.TrimExcess();
Console.WriteLine("Capacity after trim:" + numbers.Capacity);

bool areNumberLessThan6 = numbers.TrueForAll(x => x < 6);
Console.WriteLine(areNumberLessThan6);
numbers.Reverse();

numbers.ForEach(PrintToOutputWindow);
static void PrintToOutputWindow(int i)
{

    Console.WriteLine(i);
}
Console.WriteLine(numbers.IndexOf(8));

List<int> numbers1 = new List<int>() { 1, 3, 4, 6, 7, 8, 7, 3 };

Console.WriteLine(numbers1.LastIndexOf(3));

Console.WriteLine(numbers1.FindLast(x=>x<3));

List<object> multiTypeList = new List<object>() { 1, "D", false };

Console.WriteLine(multiTypeList);