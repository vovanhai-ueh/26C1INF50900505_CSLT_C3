using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session04
{
    internal class Ex3
    {
        public static void Main1s(string[] args)
        {
            read_number_v2();
        }

        static void read_number_v1()
        {
            Console.Write("Nhap 1 so tu 0-9: ");
            int so = int.Parse(Console.ReadLine());

            if (so == 0) Console.WriteLine("khong");
            else if (so == 1) Console.WriteLine("mot");
            else if (so == 2) Console.WriteLine("hai");
            else if (so == 3) Console.WriteLine("ba");
            else if (so == 4) Console.WriteLine("bon");
            else if (so == 5) Console.WriteLine("nam");
            else if (so == 6) Console.WriteLine("sau");
            else if (so == 7) Console.WriteLine("bay");
            else if (so == 8) Console.WriteLine("tam");
            else if (so == 9) Console.WriteLine("chin");
            else
                Console.WriteLine("Khong xac dinh");
        }
        static void read_number_v2()
        {
            Console.Write("Nhap 1 so tu 0-9: ");
            int so = int.Parse(Console.ReadLine());

            switch (so)
            {
                case 1: Console.WriteLine("Mot"); break;
                case 2: Console.WriteLine("Hai"); break;
                case 3: Console.WriteLine("Ba"); break;
                case 4: Console.WriteLine("Bon"); break;
                case 5: Console.WriteLine("Nam"); break;
                case 6: Console.WriteLine("Sau"); break;
                case 7: Console.WriteLine("Bay"); break;
                case 8: Console.WriteLine("Tam"); break;
                case 9: Console.WriteLine("Chin"); break;
                default:
                    Console.WriteLine("Khong xac dinh"); break;
            }
        }
    }
}
