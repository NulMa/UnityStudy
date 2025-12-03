namespace _25_12_03 {
    internal class Program {
        static void Swap(ref int a,ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main() {
            int x = 10;
            int y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"{x}, {y}")
        }
    }
}
