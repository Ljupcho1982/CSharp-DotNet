//Union
List<int> collection1=new List<int>() { 1,2,3,4,5};
List<int> collection2=new List<int>(){ 5,6,7,8,9};

IEnumerable<int> collection1and2=collection1.Union(collection2);

foreach(int item in collection1and2) {

    Console.WriteLine(item);

}

//intersection

Console.WriteLine("_____________________________________________________");
IEnumerable<int> collectionIntersection=collection1.Intersect(collection2);

foreach(int i in collectionIntersection)
{
    
    Console.WriteLine(i);
}

Console.WriteLine("_____________________________________________________");

//Exception

IEnumerable<int> exception  = collection1.Except(collection2);

foreach(int i in exception)
{

    Console.WriteLine(i);
}
