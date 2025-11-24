namespace multiplication_table {
    internal class Program {
        static void Main(string[] args) {
            for(int row = 2; row < 10; row++) {
                Console.WriteLine( row + "단 :\n");
                for(int col = 1; col < 10; col++) {
                    Console.WriteLine(row + " * " + col + " : " + col*row);
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
