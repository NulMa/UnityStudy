namespace StarTree {
    internal class Program {
        static void Main(string[] args) {
            tree();
            Console.WriteLine();

            reverseTree();
            Console.WriteLine();

            rightAngleTree();
            Console.WriteLine();

            rightAngleReverseTree();
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

            void rightAngleTree() {
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 5 - i - 1; j++) {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++) {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            void rightAngleReverseTree() {
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < i; j++) {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < 5 - i; k++) {
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
