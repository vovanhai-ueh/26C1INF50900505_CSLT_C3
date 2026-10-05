using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session09.files {
    internal class eX4 {
        public static void Main(string[] args) {
            string fp = "sample_text.txt";
            string[,] chars_appear = init_characters(fp);
            print_mang(chars_appear); //in ra mang ban dau
            //thong ke so lan xuat hien cua cac ky tu trong file text.txt
            statistic_characters(fp, chars_appear);
            //in ra ket qua thong ke
            print_mang(chars_appear);
        }
        //.Read a text file, then statistic the appearance of characters and numbers.
        public static string[,] init_characters(string file_path) {
            string[,] chars_appear = new string[2, 26];
            for (int i = 'a'; i <= 'z'; i++) {
                chars_appear[0, i - 'a'] = ((char)i).ToString();
                chars_appear[1, i - 'a'] = "0";
            }
            return chars_appear;

        }

        public static void statistic_characters(string file_path, string[,] chars_appear) {
            using (StreamReader streamReader = new StreamReader(file_path)) {
                string line;
                while ((line = streamReader.ReadLine()) != null) {
                    foreach (char c in line) {
                        if (c >= 'a' && c <= 'z') {
                            int index = c - 'a';
                            chars_appear[1, index] = (int.Parse(chars_appear[1, index]) + 1).ToString();
                        }
                    }
                }
            }
        }


        private static void print_mang(string[,] mang) {
            for (int i = 0; i < mang.GetLength(0); i++) {
                for (int j = 0; j < mang.GetLength(1); j++) {
                    Console.Write(mang[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}