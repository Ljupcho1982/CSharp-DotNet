using GroupBy_and_IGrouping;

using System.Collections.Generic;
using System.Linq;


//GroupBy


List<Person> people = new List<Person>()
{

    new Person(){FirstName="John", LastName="Smith"},

    new Person(){FirstName="Sally", LastName="Smith"},

    new Person(){FirstName="Thomas",LastName="Gioia"},

    new Person (){FirstName="Robert", LastName="Gioia"}


};

IEnumerable<IGrouping<string, Person>> groupedPeople = people.GroupBy(person => person.LastName);

foreach (IGrouping<string, Person> groupedPerson in groupedPeople)
{

    Console.WriteLine($"Key : {groupedPerson.Key}");

    foreach(var person in groupedPerson)
    {
        Console.WriteLine($"\t{person.LastName}, {person.FirstName}");

    }
}