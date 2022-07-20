

Console.WriteLine("g=green,r=red, b=blue,w=white");
int y = Console.Read();
char userInput = Convert.ToChar(y);
while (userInput != 'z')
{

    switch (userInput)
    {

        case 'g':
        Console.BackgroundColor = ConsoleColor.Green;
            break;
        case 'r':
            Console.BackgroundColor = ConsoleColor.Red;
            break;
        case 'w':
            Console.BackgroundColor = ConsoleColor.White;
            break;
        case 'b':
            Console.BackgroundColor = ConsoleColor.Blue;
            break;
        default:
            break;
       
            
    }
    Console.Clear();

    Console.WriteLine("g=green,r=red, b=blue,w=white");
    y = Console.Read();
    userInput = Convert.ToChar(y);
}






