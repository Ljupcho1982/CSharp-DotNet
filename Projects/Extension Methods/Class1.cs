using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    internal static class Greather
    {

        public static bool GratherThan(this int i,int val)
        {
            if (i > val)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
