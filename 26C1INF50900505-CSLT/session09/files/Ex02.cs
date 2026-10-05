using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session09.files {
    internal class Ex02 {
        public static void Main13(string[] args) {
            /*FileStream fs = null;
            //cloasable resources: using statement, try-finally statement
            try {
                //fs = File.Create("test.txt");
                *//*StreamWriter sw = File.AppendText("test.txt");
                sw.WriteLine("Hello World");
                sw.WriteLine("Bonjour");
                //sw.Flush();//ép ghi (khi chưa đầy bộ đệm buffer)
                sw.Close();//tự động đẩy tất cả những gì có trong bộ đệm trước khi đóng*//*

                //ghi đè
                File.WriteAllText("test.txt", "ciao mondo");


            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                if (fs != null)
                    fs.Close();
            }*/

            sample_02("xyz.txt");
        }
        public static void sample_01(string file_path) {
            /* FileStreamOptions fo = new FileStreamOptions();
             //fo......*/
            FileStream fs = File.Open(file_path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.WriteByte(65);
            Console.WriteLine(fs.Name);
            fs.Close();
        }

        public static void sample_02(string file_path) {
            FileInfo fi = new FileInfo(file_path);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.DirectoryName);
            Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.Length);
                
        }
    }
}
