using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Class1
    {

        int linearSearch(List<int> elements, int x)
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
