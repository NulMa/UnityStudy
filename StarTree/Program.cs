namespace StarTree {
    internal class Program {
        static void Main(string[] args) {
            tree();
            Console.WriteLine();
            reverseTree();
            Console.WriteLine();
            piramid();
            Console.WriteLine();
            reversePiramid();

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
        }
    }
}
