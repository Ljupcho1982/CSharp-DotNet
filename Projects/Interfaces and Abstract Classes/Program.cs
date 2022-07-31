using System.ComponentModel;
using System.Collections.Generic
using System.Collections;
using System.Diagnostics.CodeAnalysis;
public class Officer
{

    Guid id;

    public Guid id;{
    get{return id; }
set
{ id=value}

{

}




}
class Program : IEqualityComparer<officer>
{
    public bool Equals(officer? x, officer? y)
    {
        return x.Id = y.Id;
    }

    public int GetHashCode([DisallowNull] officer obj)
    {
        return obj.Id.GetHashCode();
    }
}

class Program : IEquatable<Program>
{
    public string exampleData;

}

public bool Equals([AlloNull] Program other)
{

    if (other == null)
    {

        return false;
    }

    return exampleData.GetHashCode().Equals(other.exampleData.GetHashCode());

}
class Employee
{

    public int id;
}
class Program : IComparer
{
    public int Compare(object? x, object? y)
    {
        Employee employee1 = (Employee)x;
        Employee employee2 = (Employee)y;

        return employee1.id.CompareTo(employee2.id);

    }
}

class Program : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public string Name
    {

        get
        {
            return Name;
        }

        set
        {

            Name = value;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(Name));
        }
    }
}

class Program : IComparable
{
    public int exampleLenght;
    Program ex1 = new Program() { exampleLenght = 2 };
}
{
    public int CompareTo(object? obj)
    {
        Program ex2 = (Program)obj;

        if (ex1.exampleLenght == ex2.exampleLenght)
        {

            return 0;
        }

        else if (ex1.exampleLenght > ex2.exampleLenght)
        {
            return 1;
        }

        else
        {
            return -1;
        }
    }
}

class Program : IExample,ISecondExample
{
    public void Example1()
    {
        Console.WriteLine("Hello World");
    }

    public int Example2()
    {
        return 1;
    }

    public string Example3(string string1, string string2)
    {
        return string1 + "" + string2;
    }
}

interface IExample
{
    void Example1();
    int Example2();
    string Example3(string string1, string string2);

}

interface ISecondExample
{


}