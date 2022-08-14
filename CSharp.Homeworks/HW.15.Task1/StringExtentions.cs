using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._15.Task1
{
    static class StringExtentions
    {
        public static void CutTo9 (this string str)
        {
            if (str.Length > 9)
             str = str.Remove(9) + "...";

            Console.WriteLine(str);
        }

        public static void TrueOrFalse(this string str)
        {
            if (str.Equals("TRUE")) str = "1";
            else if (str.Equals("FALSE")) str = "0";
            else throw new Exception("Data is not valid. Please, write TRUE or FALSE.");

            Console.WriteLine(str);
        }

    }
}
