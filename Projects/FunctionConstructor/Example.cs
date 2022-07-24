using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionConstructor
{
    internal class Example
    {
        int exampleNumber;
        string exampleName;

        public Example(int num, string name)
        {
            exampleNumber = num;
            exampleName = name;
        }

      public void Example1()
        {

            Console.WriteLine($"The name is: {exampleName} and age is: {exampleNumber}");
        }
    }
}
