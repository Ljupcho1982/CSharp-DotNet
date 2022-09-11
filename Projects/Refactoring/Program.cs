//Without Refactoring
List<string> ExampleData=new List<string>() { "sample","solution", "programming","solve","computer"};

 string [] words;

words = new string[5];

for (int i = 0; i < ExampleData.Count; i++)
{

    if (ExampleData[i][0].Equals('s'))
    {

        words[i] = ExampleData[i];
    }
}

for(int i =0; i < words.Length; i++)
{

    Console.WriteLine(words[i]);
}

//With Refactoring

for(int i=0; i < ExampleData.Count; i++)
{

    if (ExampleData[i][0].Equals('s'))
    {

        Console.WriteLine(ExampleData[i]);
    }
}