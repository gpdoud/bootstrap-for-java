using System;

namespace JavaSumNbrsOneToTwentyDivisibleByThreeOrFive {
    class Account { }
    class Savings : Account { }
    class Program {
        static void Main(string[] args) {
            (new Program()).Run();
        }

        void Run() {

            var total = 0;
            // iterate the numbers 1 to 20
            for(int i = 1; i <=20; i++) {

                // check divisibility by 3 or 5
                if(i % 3 == 0 || i % 5 == 0) {
                    total += i;
                }

            }
            // display the sum
            Console.WriteLine($"The total is {total}");

            int[] ints = { 1, 2, 3, 4, 5 };
            foreach(var i in ints) { }
        }
    }
}
