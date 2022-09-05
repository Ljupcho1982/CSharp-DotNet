using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Program1.MultiplyWithExtras(1,2));
        }

        class Program1
        {

            private static int number1 = 3;
            private static int number2 = 5;

            public static int MultiplyWithExtras(int num1, int num2)
            {

                return num1 * num2+number1+number2;
            }
        }
    }
}
