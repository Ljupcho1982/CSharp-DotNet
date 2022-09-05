using System;

namespace Inheretance
{
    internal class Program
    {
         static void Main(string[] args)
            {
                Program2 example = new Program2();
            example.Print();


            

          

            }

       public class Program1
        {

           

            public  void Print()
            {

                Console.WriteLine("Hello World");
            }

         
        }
        public class Program2 : Program1
            {
            
           
        }

    }
}
