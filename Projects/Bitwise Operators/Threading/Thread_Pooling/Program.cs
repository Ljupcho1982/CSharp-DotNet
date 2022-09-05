using System.Threading;



static void Example1(Object stateInfo)
{

    Console.WriteLine("Example1");
}

static void Example2(Object stateInfo)
{

    Console.WriteLine("Example2");
}

 static void Example3(Object stateInfo)
{

    Console.WriteLine("Example3");
}


ThreadPool.QueueUserWorkItem(Example1);
ThreadPool.QueueUserWorkItem(Example2);

ThreadPool.QueueUserWorkItem(Example3);
Console.WriteLine("Thread count: " + ThreadPool.ThreadCount);

Thread.Sleep(3000);