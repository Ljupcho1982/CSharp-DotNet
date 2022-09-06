using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

ConcurrentBag<int> bag=new ConcurrentBag<int> ();
List<Task> tasks=new List<Task> ();
for (int i = 0; i < 100; i++)
{

    var numberAdd = i;
    tasks.Add(Task.Run(()=>bag.Add(numberAdd)));
}

Task.WaitAll(tasks.ToArray());

List<Task> runningTasks = new List<Task> ();
int numberOfItems = 0;

while (!bag.IsEmpty)
{
    runningTasks.Add(Task.Run(() =>
    {
        int item;

        if (bag.TryTake(out item))
        {

            Console.WriteLine(item);
            numberOfItems++;
        }

    }));

};

Task.WaitAll (runningTasks.ToArray());

Console.WriteLine($"There were {numberOfItems} items in the bag");
