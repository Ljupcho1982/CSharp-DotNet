﻿
Console.WriteLine("Ljupcho Shemov");
static void ExampleFunction()
{
    for(int i=0; i < 1000; i++)

    Console.WriteLine("Hello World");
}

Thread t = new Thread(ExampleFunction);
t.Start();

t.IsBackground = true;
