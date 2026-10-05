using _26C1INF50900505_CSLT.session06;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _26C1INF50900505_CSLT.session09
{
    internal class Ex01
    {
        public static void Main1(string[] args)
        {
            /*string s = "sequential";
            Console.WriteLine(s);
            s = "hello world";
            Console.WriteLine(s);

            string s1 = new string("welcome to the hell");
            String s2 = "xin chào pà kon";
            
            StringInfo si1 =new StringInfo(s1);
            StringInfo si2 =new StringInfo(s2);

            Console.WriteLine(si1);
            Console.WriteLine(si2);*/

            string s1 = "Hello world";
            string s2 = "xin chào";
            s2 = s1;

            s2 = "bonjour";
            Console.WriteLine(s2);//bonjour
            Console.WriteLine(s1);//-->?

        }
    }
}
