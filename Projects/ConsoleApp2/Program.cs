using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int linearSearch(List<int> elements, int x)
            {
                int length = elements.Count;

                for (int i = 0; i < length; i++)
                {

                    if (elements[i] == x)
                    {

                        return i;
                    }
                }
                return -1;
            }
            List<int> elements = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine(linearSearch(elements, 3));
        }
    }
    }

