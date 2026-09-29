using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session08
{
    internal class Ex01
    {
        public static void Mainxx(string[] args)
        {
            /*int[,] a = new int[2, 3];//rec

            int[][] ja = new int[3][];
            int[][] ja1 = new int[3][];
            ja1[0] = new int[1] { 1 };
            ja1[1] = new int[2] { 2,3 };
            ja1[2] = new int[3] { 4,5,6 };


            Xuatmang(ja1);
            Console.WriteLine();
            Xuatmang_V2(ja1);*/

            int[][] ja2 = new int[5][];
            NhapMangNgauNhien(ja2);
            Xuatmang_V2(ja2);
        }

        static void NhapMangNgauNhien(int[][] a)
        {
            Random rnd =new Random();
            for (int i = 0; i < a.Length/*rows*/; i++)
            {
                //cấp phát vùng nhớ (số cột) cho mỗi dòng
                a[i] = new int[rnd.Next(3,10)];
                for (int j = 0; j < a[i].Length /*No Columns of row j-th*/ ; j++)
                {
                    a[i][j] = rnd.Next(1, 30);
                }
            }
        }

        static void Xuatmang(int[][] a)
        {
            for (int i = 0; i < a.Length/*rows*/; i++)
            {
                for(int j = 0; j < a[i].Length /*No Columns of row j-th*/ ; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }            
        }
        static void Xuatmang_V2(int[][] a)
        {
            foreach (int[] row in a)//với mỗi dòng trong mảng a
            {
                foreach (int col in row) //với mỗi cột của dòng
                {
                    Console.Write($"{col}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
