// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime dateTime = new DateTime(2020, 1, 19);

Console.WriteLine(dateTime);

TimeSpan timeSpan = new TimeSpan(1, 2, 0);
Console.WriteLine(timeSpan.Hours);
Console.WriteLine(timeSpan.Minutes);
Console.WriteLine(timeSpan.Seconds);
Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));

Console.WriteLine(DateTime.UtcNow.ToString());

DateTime sum = dateTime + timeSpan;
Console.WriteLine(sum);

DateTime currentDate = DateTime.Now;
DateTime xmass = new DateTime(2022,12,25);

DateTime year1 = DateTime.Now;

var difrence = xmass - year1;

Console.WriteLine(difrence);

Console.WriteLine("There are:{0} days left until xmass",difrence.Days);










