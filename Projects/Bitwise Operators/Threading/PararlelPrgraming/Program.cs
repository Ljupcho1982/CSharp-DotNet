using System.Net;
using System.Threading.Tasks;

Parallel.Invoke(

    ()=>new WebClient().DownloadFile("http://www.google.com","google.html"),
    ()=>new WebClient().DownloadFile("http://www.yahoo.com","yahoo.html")


    );
Parallel.For(0, 200, i => Console.WriteLine("Hello World"));
