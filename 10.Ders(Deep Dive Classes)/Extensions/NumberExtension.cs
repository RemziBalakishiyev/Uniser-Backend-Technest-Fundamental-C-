using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ders_Deep_Dive_Classes_.Extensions
{
    static class NumberExtension
    {
        public static int Multp10(this int number)
        {
            return number * 10;
        }
    }

    static class ObjExtension
    {
        public static bool isEqual(this object value,object equalitValue)
        {
            return value == equalitValue;
        }
    }
}
