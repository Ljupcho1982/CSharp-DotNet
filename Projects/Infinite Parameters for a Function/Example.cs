using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Parameters_for_a_Function
{
    internal class Example
    {

        public  void Example1(params string[] words)
        {

            foreach(string word in words)
            {

                Console.WriteLine(word);    
            }
        }


    }
}
