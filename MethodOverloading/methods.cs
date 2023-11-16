using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class methods
    {
        public static int Add(int d, int x)
        {
            return d + x;
        }

        public static decimal Add(decimal e, decimal g)
        { 
            return e + g;
        }

        public static string Add(int b, int r, bool withdollars)
        {
            if (withdollars && (b + r) != 1) 
            {
                return $"{b + r} dollars"; //or return (b + r).ToString() + Dollars;
            }
            else if (withdollars && (r + b) == 1) 
            {
                return $"{b + r} dollar";
            }
            else
            {
                return $"{b + r}";
            }
        }

    }
}
