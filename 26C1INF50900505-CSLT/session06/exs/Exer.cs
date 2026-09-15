using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session06.exs
{
    internal class Exer
    {
        /// <summary>
        /// Ham kiem tra 1 so co phai la so ngto hay khong
        /// </summary>
        /// <param name="so">la so can kiem tra</param>
        /// <returns>true neu so la so ngto, gnuoc lai tra ve false</returns>
        static bool ISPrime(int so)
        {
            for (int i = 2; i <= so / 2; i++)
                if (so % i == 0) //ton tai mot uoc so khac 1 va chinh no -->khong la so nguyen to
                    return false;
            return true;
        }

        /// <summary>
        /// In ra cac so nguyen to nho hon  n
        /// </summary>
        /// <param name="n">la gioi han</param>
        static void PrintPrimNumbersUnderN(int n)
        {
            for(int i=2;i<n;i++)
                if(ISPrime(i))
                    Console.Write($"{i}, ");
        }

        /// <summary>
        /// In ra N so nguyen to dau tien
        /// </summary>
        /// <param name="n"></param>
        static void PrintFirstN_PrimeNumbers(int n)
        {
            int so = 2;
            int dem = 0;
            while (dem < n)
            {
                if (ISPrime(so))
                {
                    Console.Write($"{so}, ");
                    dem++;
                    if(dem%15==0)
                        Console.WriteLine();
                }
                so++;
            }
        }

        public static void Main(string[] args)
        {
            /*Console.Write("Nhap 1 so can kiem tra: ");
            int so = int.Parse(Console.ReadLine());
            bool kq = ISPrime(so);
            if(kq)
                Console.WriteLine($"so {so} la so nguyen to");
            else
                Console.WriteLine($"so {so} KHONG la so nguyen to");*/

            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"cac so nguyen to nho hon {n}");
            PrintPrimNumbersUnderN(n);
            Console.WriteLine();
            Console.WriteLine($"{n} so nguyen to dau tien:");
            PrintFirstN_PrimeNumbers(n);
        }

    }
}
