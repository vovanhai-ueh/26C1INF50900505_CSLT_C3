using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session08
{
    internal class TestArray
    {
        public static void Maixn(string[] args)
        {
            int[] a = { 5, 4, 3, 7, 2, 9 };
            Array.Sort(a);

            foreach(var i in a)
                Console.Write($"{i}, ");

            
        }
    }
}
