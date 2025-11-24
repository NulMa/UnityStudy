namespace StarTree {
    internal class Program {
        static void Main(string[] args) {
            tree();
            Console.WriteLine();
            reverseTree();
            Console.WriteLine();
            checkOddEven();
            Console.WriteLine();

            void tree() {
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j <= i; j++) {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            void reverseTree() {
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 5 - i; j++) {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            void checkOddEven() {
                for (int i = 1; i <= 10; i++) {
                    if (i % 2 == 0) {
                        Console.WriteLine(i + " is even");
                    }
                    else {
                        Console.WriteLine(i + " is odd");
                    }
                }
            }
        }
    }
}
