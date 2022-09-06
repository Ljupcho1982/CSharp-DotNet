//OrderBy

using OrderBy__ThenBy_and_Reverse;

List<Person> people = new List<Person>()
{
new Person(){Name="Zach", Age=25},
new Person(){Name="Robert", Age=39},
new Person() {Name="John", Age=23},
new Person() {Name="Albert", Age=49}

};

//In ascending order
IOrderedEnumerable<Person> ascendingNames = people.OrderBy(x => x.Name);

foreach (Person person in ascendingNames)
{
    Console.WriteLine(person.Name);

}

//In descending order
IOrderedEnumerable<Person> desendingNames = people.OrderByDescending(x => x.Name);

foreach (Person person in desendingNames)
{
    Console.WriteLine(person.Name);

}

//ThenBy

IOrderedEnumerable<Person> ascendingNames1 = people.OrderBy(x => x.Name).ThenBy(x=>x.Age);

foreach (Person person in ascendingNames1)
{
    Console.WriteLine(person.Age);

}