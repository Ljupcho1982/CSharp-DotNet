/// Experssion Lambda

Action debug = () => Console.WriteLine("Hello World");

debug();



///Statement Lambda

Action debug1 = () =>
{

    Console.WriteLine("Hello World");
    Console.WriteLine("Hello World");
    Console.WriteLine("Hello World");
};

debug1();

/// Parameter in Lambda function

Action<string> debug2 = (s) => Console.WriteLine(s);

debug2("Example");