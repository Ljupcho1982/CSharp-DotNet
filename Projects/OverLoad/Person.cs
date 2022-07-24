using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad
{
    internal class Person
    {

       public void Data(string name, int age)
        {
            name = name;
            age = age;

            Console.WriteLine($"Your name is {name} and you age is {age}");
        }

       public void Data(int age, string name)
        {
            age = age;
            name = name;
            Console.WriteLine($"Your age is:{age} and your name is {name}");
        }

        public void Data(string name, int age, string id)
        {

            name = name;
            age = age;
            id = id;

            Console.WriteLine($"Your name is :{name} your age is {age} and your id is {id}");
        }
    }
}
