using LinearSearch;

//Class1.List = new List<int> { 1, 2, 3, 4 };
//int result = Class1.linearSearch(Class1.List, 3);

//if (result != -1)
//{
//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("item not found!");
//}


int linearSearch(List<int> elements, int x)
{
    int length = elements.Count;

    for (int i = 0; i < length; i++)
    {

        if (elements[i] == x)
        {

            return i;
        }
    }
    return -1;
}

List<int> elements = new List<int>() { 1, 2, 3, 4, 5 };

int result = linearSearch(elements, 3);

Console.WriteLine(result);







//List<int> lst = new List<int>
//    {
//    1,2,3,4,5,6
//    };

//Console.WriteLine(linearSearch(list, 5));







//LinearSearch List<int> elements = new List<int>() { 1, 2, 3, 4, 5 };

//Console.WriteLine(one.linearSearch(elements, 3));


