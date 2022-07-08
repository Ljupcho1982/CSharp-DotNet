using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {

        public string name { get; set; }

        public int height { get; set; }

        public string eyeColor { get; set; }

        public int weight { get; set; }

        public string rase { get; set; }

        public void Person1()
        {
            Console.WriteLine("$The height is:  {1}cm the eyes are: {2} the weight is: {3}kg the rase is: {4}",name,height,eyeColor,weight,rase);

        }
    }
}
