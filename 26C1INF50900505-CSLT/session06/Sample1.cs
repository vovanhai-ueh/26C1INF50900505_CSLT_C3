using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session06
{
    internal class Sample1
    {
       

        public static void Maine4wrw(string[] args)
        {
            Sample1 s = new Sample1();
            int x = s.add(3, 4);

            Console.Write("Nhap so a = "); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = "); int b = int.Parse(Console.ReadLine());

            int c = tintoan(a,b);

            Console.WriteLine(c);
        }

        public int add(int a, int b)
        {
            return a + b;
        }

        public double add(float a, int b)
        {
            return a + b;
        }

       

        public int add(int a, float b)
        {
            return (int)b + a;
        }

        public int add(int a, int b, int c)
        {
            return a + b;
        }




        public static int tintoan(int a, int b)
        {
           
            int c = a + b;
            return c;
        }


        static void InHoa(string s)
        {
            if(string.IsNullOrEmpty(s))
                return;///
            Console.WriteLine(s.ToUpper());
           
        }
    }
}
