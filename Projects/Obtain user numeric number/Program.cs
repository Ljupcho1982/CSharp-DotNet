Console.WriteLine("\n Please enter a number");

do
{
    string userInput = Console.ReadLine();
    int number;
    if (!int.TryParse(userInput, out number))
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("You entered invalid input");
        Console.ResetColor();
        Console.WriteLine("\n Please enter a number:");

    }
    else
    {
        Console.WriteLine("\n Thanks! Enter another number: ");
    }
} while (true);