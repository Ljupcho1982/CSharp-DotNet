using System.Collections;
ArrayList collection=new ArrayList() { "a",2,"b",4,"c",6}; 

IEnumerable<string> collectionOfStrings=collection.OfType<string>();

foreach(string str in collectionOfStrings)
{

    Console.WriteLine(str+ " ");

}

Console.WriteLine(string.Empty);


List<int> collectionsint=new List<int> { 1,2,3,4,5,6 };

IEnumerable gretaerthan3 = collectionsint.Where(x => x > 3);

foreach(int i in gretaerthan3)
{

    Console.WriteLine(i + " ");   
}

Console.WriteLine(string.Empty);
    