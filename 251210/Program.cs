namespace _251210 {
    internal class Program {

        static void Boo(int[] y) {
            y[0] = 10;
            y = new int[3];
            y[0] = 7;

            for(int i = 0;i < y.Length; i++) {
                Console.WriteLine("Boo : " + y[i]);
            }
        }

        static void Foo(ref int[] x) {
            x[0] = 10;
            x = new int[3];
            x[0] = 7;

            for (int i = 0; i < x.Length; i++) {
                Console.WriteLine("Foo : " + x[i]);
            }
        }

        static void Main() {
            int[] arr = { 1, 2, 3 };
            int[] arr2 = { 1, 2, 3 };
            Boo(arr);
            Console.WriteLine();
            Foo(ref arr2);
        }
    }
}
