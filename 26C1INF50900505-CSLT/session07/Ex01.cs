using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session07
{
    internal class Ex01
    {

        
        public static void Main333(string[] args)
        {
            /* int[] mang;//mang-->null ~declaration
             mang = new int[2]; //~ instantiation (memory allocation)

             //initialization
             int[] mang2 = new int[2];*/


            /*int[] mang3 = new int[2];
            mang3[0] = 1; mang3[1] = 2;*/

            //int[] mang3 = new int[2] { 1, 2 };

            //int[] mang3 = { 1, 2 };

            /*Console.Write("Nhap so phan tu mang N = ");
            int N = int.Parse(Console.ReadLine());*/


            int N = 100;
            int[] mang = new int[N];

            //nhapmang_com(mang);
            nhapmang_random(mang);
            Console.WriteLine("\nMang sau khi nhap");
            in_mang(mang);

            int m = tim_Max_mang(mang);
            Console.WriteLine($"\nmax = {m}");
            in_nguyeto(mang);
            Console.WriteLine();
            doi_gtri(mang,-1);
            in_mang(mang);
        }

        static void nhapmang_random(int[] a)
        {
            Random rnd =new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 500);
            }
        }

        static void nhapmang_com(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void in_mang(int[] a)
        {
            foreach(int v  in a)
                Console.Write($"{v}, ");
        }

        /* static ???? do_fooo(int[] a)
         {
             for (int i = 0; i < a.Length; i++)
             {
                 //do on a[i]
             }
         }*/

        static int tim_Max_mang(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }

        static void doi_gtri(int[] a, int rep)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    a[i] = rep;
            }
         }

        static void in_nguyeto(int[] a)
        {
            /* for (int i = 0; i < a.Length; i++)
             {
                 if(IsPrime(a[i]))
                     Console.Write($"{a[i]}, ");
             }*/
            foreach (int v in a)
                if(IsPrime(v))
                    Console.Write($"{v}, ");
        }

        public static bool IsPrime(int v)
        {
            if (v < 2) return false;
            for (int i = 2; i <= v / 2; i++)
                if (v % i == 0)
                    return false;
            return true;
        }
    }
}
