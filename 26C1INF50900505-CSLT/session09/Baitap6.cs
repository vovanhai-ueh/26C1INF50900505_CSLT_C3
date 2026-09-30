using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace _26C1INF50900505_CSLT.session09
{
    internal class Baitap6
    {
        //-to count the number of vowels or consonants in a string.
        static int count_vowels(string s) 
        {
            int dem = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (   s[i] == 'a' 
                    || s[i] == 'e' 
                    || s[i] == 'i' 
                    || s[i] == 'o' 
                    || s[i] == 'u')
                    dem++;

                if ("ueoai".Contains(s[i]))
                    dem++;
            }

            return dem;
        }
    }
}
