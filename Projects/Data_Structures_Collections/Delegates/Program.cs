
Print print = null;
print += HelloWorld;
print += GoodByeWorld;


print();


 void GoodByeWorld()
{

    Console.WriteLine("GoodBye World");
}


void HelloWorld()
{

    Console.WriteLine("Hello World");
}

delegate void Print();


