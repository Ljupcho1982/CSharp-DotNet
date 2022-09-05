using System;

namespace Generic
{
    internal class Program<TSession>
    {
        static void Main(string[] args)
        {


        }

        interface IExample3 { }
        class Example2 { }

        class Example<T, U> where T : Example2, IExample3
                            where U : Example2
        {


        }
    }
}
