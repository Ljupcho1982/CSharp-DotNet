ConsoleKeyInfo keyInfo;

//Prevent by clicking z to terminate the console
Console.TreatControlCAsInput = true;
do
{

    keyInfo = Console.ReadKey();
    if((keyInfo.Modifiers & ConsoleModifiers.Alt)!=0)
        Console.WriteLine("ALT+");
    if((keyInfo.Modifiers& ConsoleModifiers.Shift)!=0)
        Console.WriteLine("SHIFT+");

    Console.WriteLine(keyInfo.Modifiers.ToString());
} while (keyInfo.Key != ConsoleKey.Escape);

