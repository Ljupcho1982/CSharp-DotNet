using System.Collections.Generic;

using System.Diagnostics;

Queue<string> queue = new Queue<string>();
queue.Enqueue("a");
queue.Enqueue("b");
queue.Enqueue("c");

foreach(var item in queue)
{

    Console.WriteLine(item);
}
System.Diagnostics.Debug.WriteLine(queue.Dequeue());
System.Diagnostics.Debug.WriteLine(queue.Peek());
