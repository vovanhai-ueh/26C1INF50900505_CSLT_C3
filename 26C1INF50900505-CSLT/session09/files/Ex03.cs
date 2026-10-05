using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session09.files {
    internal class Ex03 {

        public static void Mainddd(string[] args) {
            //randomGenerateNumber("numbers.txt");
            int[]arr = readNumbersFromFile("numbers.txt");
            printEvenNumbers(arr);
        }

        static void printEvenNumbers(int[] arr) {
            Console.WriteLine("Even numbers in the array:");
            foreach (int number in arr) {
                if (number % 2 == 0) {
                    Console.Write(number+", ");
                }
            }
        }
        //tạo file với 100 số ngẫu nhiên có giá trị từ 1-20 rồi đọc lên 1 mảng 1 chiều.
        //In ra các phần tử của mảng là số chẵn

        static void randomGenerateNumber(string file_path) {
            StreamWriter streamWriter = null;
            using (streamWriter = new StreamWriter(file_path)) {//.tự động đóng streamWriter khi thoát khỏi using
                Random random = new Random();
                for (int i = 0; i < 100; i++) {
                    int number = random.Next(1, 21);
                    //streamWriter.Write(number + ",");
                    streamWriter.WriteLine(number);
                }
            }
            Console.WriteLine("gen finished");
        }

        static int[] readNumbersFromFile(string file_path) {
            int[] numbers = new int[100];
            using (StreamReader streamReader = new StreamReader(file_path)) {
                for (int i = 0; i < 100; i++) {
                    string line = streamReader.ReadLine();
                    if (line != null) {
                        numbers[i] = int.Parse(line);
                    }
                }
            }
            return numbers;
        }
    }
}
