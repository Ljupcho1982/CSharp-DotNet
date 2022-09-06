using System.Collections;
using System.Linq;

List<int> collection = new List<int>() { 1, 2, 3 };

IEnumerable<int> collectionOfintsMultiplyedBy2 = collection.Select(s => s * 2);
foreach(int i in collectionOfintsMultiplyedBy2)
{

    Console.WriteLine(i.ToString() + " ");
}

Console.WriteLine(String.Empty);

List<List<int>> collections = new List<List<int>>()
{

    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5, 6 },
    new List<int> { 7, 8, 9 },
};

IEnumerable<int> result = collections.SelectMany(list => list);

Console.WriteLine(result.Count().ToString());

foreach(int i in result)
{

    Console.WriteLine(i.ToString()+" ");
}

Console.WriteLine(String.Empty);