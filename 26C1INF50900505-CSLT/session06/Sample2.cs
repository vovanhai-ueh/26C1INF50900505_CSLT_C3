using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session06
{
    internal class Sample2
    {
        static void swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
            Console.WriteLine($"ben trong ham x={x}, y={y}");
        }

        public static void Main111(string[] args)
        {
            /*int a = 7, b = 5;
            Console.WriteLine($"Truoc khi hoan doi a={a}, b={b}");
            swap(ref a,ref b);
            Console.WriteLine($"Sau khi hoan doi a={a}, b={b}");*/

            int x;
            khoi_gan(out x);
        }


        static void khoi_gan(out int a)
        {
            a = 10;
        }
    }
}
