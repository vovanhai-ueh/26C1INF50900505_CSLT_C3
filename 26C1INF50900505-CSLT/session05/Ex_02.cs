using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session05 {
    internal class Ex_02 {
        public static void Main444(string[] args) {
            /*string ueh = "University of Economics Ho Chi Minh";
            Console.WriteLine(ueh);

            foreach(char c in ueh) {
                Console.WriteLine(c);
            }*/
            /*ex4();
            ex5();*/
            ex6();
        }

        static void ex4() {
            int n = 5;
           
            for(int i = 1; i <= n; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        static void ex5() {
            int n = 5;
            int so= 1;
            for (int i = 1; i <= n; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write($"{so++} ");
                }
                Console.WriteLine();
            }
        }

        static void ex6() {
            Console.Write("nhap n = ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0d;
            for (int i = 1; i <= n; i++) {
                sum += 1d / i;
            }
            Console.WriteLine($"Sum = {sum:0.000}");
        }

        static void ex6_1() {
            Console.Write("nhap n = ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0d;
            /* for (int i = 1; i <= n; i++) {
                 sum += 1d / i;
             }*/
            int i = 1;
            while (i <= n) {
                sum += 1d / i;
                i++;
            }
            Console.WriteLine($"Sum = {sum:0.000}");
        }
    }
}
