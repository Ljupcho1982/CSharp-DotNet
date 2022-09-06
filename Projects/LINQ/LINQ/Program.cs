
using LINQ;


List<Person> people = new List<Person>()
{

    new Person() {Name="John", Age=30},
    new Person() {Name="Sarah", Age=25},
    new Person() {Name="James", Age=32},
    new Person() {Name="Joseph", Age=24},


};

int oldestPerson = people.Select(x => x.Age).Max();
Console.WriteLine(oldestPerson);



