using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _26C1INF50900505_CSLT.session06
{
    internal class ex3
    {
        public static float calc_GPA(float toan=0, float ly=0, float hoa=0)
        {
            return toan * 2f + ly * 1.5f + hoa;
        }

        public static void Mainxxx(string[] args)
        {
            /* float toan = 5.5f, ly = 7f, hoa = 6f;

             calc_GPA();

             float gpa = calc_GPA(toan, ly, hoa);//indexed
             Console.WriteLine(gpa);
             float gpa_n = calc_GPA(ly: ly, hoa: hoa, toan: toan);//named
             //float gpa_n = calc_GPA(ly, hoa, toan);//sai
             Console.WriteLine(gpa_n);*/

            int kq = sum(1, 2);
            int kq1 = sum(1, 2,3);
            int kq2 = sum(1, 2, 3, 4);
            int kq3 = sum(1);
            int kqX = sum(1, 2, 3, 4, 43, 6, 3, 6, 57, 3, 54, 36);
            Console.WriteLine(kq);
            Console.WriteLine(kq1);
            Console.WriteLine(kq2);
            Console.WriteLine(kq3);
            Console.WriteLine(kqX);
        }


        public static int sum(params int[]p)
        {
            int k = 0;
            foreach(int x in p)
                k += x;
            return k;
        }

    }
}
