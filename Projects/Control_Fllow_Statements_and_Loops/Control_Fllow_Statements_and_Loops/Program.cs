// See https://aka.ms/new-console-template for more information

//If Statement
if (1 < 2)
{


    if (false)

    {

        Console.WriteLine("You hit the second if");
    }
    else
    {
        Console.WriteLine("Else was hit");
    }
}

//Switch statement

int value = 2;

switch (value)
{

    case 1:
        Console.WriteLine("1");
        break;
    case 2:
        Console.WriteLine("2");
        break;
    case 3:
        Console.WriteLine("3");
        break;
    case 4:
        Console.WriteLine("4");
        break;
    case 5:
        Console.WriteLine("5");
        break;
    case 6:
        Console.WriteLine("6");
        break;
    case 7:
        Console.WriteLine("7");
        break;
    case 8:
        Console.WriteLine("8");
        break;
    case 9:
        Console.WriteLine("9");
        break;
    case 10:
        Console.WriteLine("10");
        break;
    default:
    Console.WriteLine("0");
        break;
}
//switch statement days of the week
string message = "";
int day = 3;
switch (day)
{
    case 1:
        message="Sunday";
        break;

    case 2:
        message="Monday";
        break;
    case 3:
        message = "Thusday";
        break;

    case 4:
        message = "Wednesday";
        break;

    case 5:
        message = "Thursday";
        break;
    case 6:
        message = "Friday";
        break;
    case 7:
        message = "Saturday";
        break;
    default:
        message = "No day";
        break;
}
Console.WriteLine(message);

//for loops

for(int i = 0; i < 5; i++)
{
    await Task.Delay(100);
    Console.WriteLine("Hello World");
}
string example = "abc";

for(int i = 0; i < example.Length; i++)
{
    await Task.Delay(100);

    Console.WriteLine(example[i]);
};

// for loop revers

for(int i = example.Length - 1; i >= 0; i--)
{
    await Task.Delay(100);
    Console.WriteLine(example[i]);
}

//outside foor loop
//int i = 0;

/* for (; ; ){

    if (i < 4)
    {

        Console.WriteLine(i.ToString());
        i++;
    }
};*/

// nested loop

for (int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {

        Console.WriteLine("i= "+ i.ToString() + " " + "j= " + j.ToString());
    }

}

//foreach loop

List<string> myFriends = new List<string> {
    "Emma", "Rupert", "Daniel", "Maggie", "Alan"
};

Console.WriteLine("Enter a valid name!");
var name = Console.ReadLine();
int index = myFriends.IndexOf(name);
Console.WriteLine(index);
/*
int index = 0;
foreach (var friend in myFriends)
{
   Console.WriteLine($"Friend {index}: {friend}");
    index++;
}
*/

//select


// index of in for loop




   
