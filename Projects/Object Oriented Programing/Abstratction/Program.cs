using System;

namespace Abstratction
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Class1 example=new Class1();

            example.message();

        }

        public abstract class AbstractClass
        {


        }

        public class Class1:AbstractClass
        {

            public void message()
            {
            Console.WriteLine("Abstract Class");

            }
            

        }
    }
}
