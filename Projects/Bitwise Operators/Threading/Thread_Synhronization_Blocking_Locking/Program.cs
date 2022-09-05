using System.Threading;
static void Example1()
{

    Console.WriteLine("1");
    Console.WriteLine("2");
    Console.WriteLine("3");
    Console.WriteLine("4");
    Console.WriteLine("5");
    Console.WriteLine("6");

}

static void Example2()
{

    Console.WriteLine("6");
    Console.WriteLine("7");
    Console.WriteLine("8");
    Console.WriteLine("9");
    Console.WriteLine("10");
}

Thread t1=new Thread(Example1);

Thread t2=new Thread(Example2);

t1.Start();

t2.Start();
t1.Join();

Console.WriteLine(DateTime.Now.ToString());

Thread.Sleep(1000);

Console.WriteLine(DateTime.Now.ToString());

