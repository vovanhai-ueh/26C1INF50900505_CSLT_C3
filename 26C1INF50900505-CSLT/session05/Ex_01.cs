

namespace _26C1INF50900505_CSLT.session05 {
    internal class Ex_01 {
        public static void Main33(string[] args) {
            /*for(int i = 0; i < 10; i++) {
                Console.WriteLine( $"i = {i}");
            }*/

            /*for(; ; ) {
                Console.WriteLine("Vong lap vo han");
                //thoát: dùng break để thoát khỏi vòng lặp vô hạn
            }*/
            /*for(int i=1, j=10; i < j; i++, j--) {
                Console.WriteLine($"i = {i}, j = {j}");
            }*/
            //nested for loop
            /*for (int i = 1; i <= 5; i++) {
                for (int j = 1; j <= 5; j++) {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
                Console.WriteLine("-------------------");
            }*/

            for(int i =2; i <= 10; i++) {
                /*if (i == 5)
                    break;//dùng break để thoát khỏi vòng lặp*/
                if(i==5)
                    continue;//dùng continue để bỏ qua vòng lặp hiện tại và tiếp tục vòng lặp tiếp theo

                for (int j = 1; j <= 10; j++) {
                    /*if (j == 5)
                        break;//dùng break để thoát khỏi vòng lặp*/
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine("-------------------");
            }
        }
    }
}
