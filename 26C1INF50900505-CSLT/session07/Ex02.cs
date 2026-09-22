using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session07
{
    internal class Ex02
    {
        public static void Main(string[] args)
        {


            /*int[,] mang2 = new int[3, 4];
            int[,] mang3 = new int[3, 4] { 
                { 1, 2, 3, 4 }, 
                { 5, 6, 7, 8 }, 
                { 9, 10, 11, 12 }
            };

            int[,] mang4 = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };*/
            int rows = 5, cols = 7;

            int[,] mang;
            mang = new int[rows, cols];

            //in_mang(mang);

            //nhap_mang(mang);
            sinh_mang(mang);
            in_mang(mang);
            Console.WriteLine();
            int mr = max_row(mang, 2);
            Console.Write($"\nmax row {2} = {mr}");
            int mc = max_columns(mang, 1);
            Console.Write($"\nmax column {1} = {mc}");
            Console.WriteLine("\n cac so nguyen to co trong mang 2 chieu");
            in_snt(mang);

            Console.WriteLine();
            Console.Write("Ban muon tim so nao? ");
            int k = int.Parse(Console.ReadLine());

            int[] res = Search(mang, k);
            if (res[0]==-1)
                Console.WriteLine("khong tim thay");
            else
                Console.WriteLine($"{k} đuoc tim thay o dong {res[0]} cot {res[1]}");
        }
        //Tìm giá trị k trong mảng a
        //tìm thấy trả về chỉ số dòng,cột
        static int[] Search(int[,]a, int k)
        {
            int[] kq = new int[2] { -1,-1};//pt 0 là dòng, pt 1 là cột

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] == k) //tìm thấy
                    {
                        kq[0] = i;
                        kq[1] = j;
                    }
                }
            }
            return kq;
        }

        static void in_snt(int[,] a)
        {
            foreach(int v in a)
                if (Ex01.IsPrime(v))
                    Console.Write($"{v}, ");
        }
        static int max_row(int[,] a, int r)
        {
            int max = a[r, 0];
            for(int j=1; j < a.GetLength(1); j++)
            {
                if (a[r,j]>max)
                    max = a[r,j];
            }
            return max;
        }

        static int max_columns(int[,] a, int c)
        {
            int max = a[0, c];
            for (int i=1;i<a.GetLength(0); i++)
            {
                if (a[i, c] > max)
                    max = a[i, c];
            }
            return max;
        }

        static void nhap_mang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }


        static void sinh_mang(int[,] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(1, 30);
                }
            }
        }

        static void in_mang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]}\t");
                   
                }
                Console.WriteLine();
            }
        }
    }
}
