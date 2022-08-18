using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal static class Class1
    {
        public static List<int> List { get; set; }


        public static int linearSearch(List<int> elements, int x)
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

    }
}
