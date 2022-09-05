using System.Threading;


Thread t = new Thread(Example);
t.Priority = ThreadPriority.BelowNormal;

 static void Example()
{
    Console.WriteLine("hhh");

}