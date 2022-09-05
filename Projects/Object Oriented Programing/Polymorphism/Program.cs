using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class2();
            obj.Example();

        }

        public class Class1
        {

            public virtual void Example()
            {

                Console.WriteLine("Class 1 `s Example method");
            }
        }

        public class Class2 : Class1
        {

            public override void Example()
            {

                Console.WriteLine("Class 2 `s Example method");
            }
        }


    }
}
