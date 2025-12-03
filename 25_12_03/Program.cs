namespace _25_12_03 {
    internal class Program {

        static void Main() {
            int result = cumculativeSum(1, 6);
            Console.WriteLine(result);
        }
        static void Swap(out int a, out int b) {
            a = 0;
            b = 0;
            int temp = a;
            a = b;
            b = temp;
        }

        static int cumculativeSum(int strt, int nd) {
            if (strt > nd)
                return 0;

            return strt + cumculativeSum(strt + 1, nd);
        }

        // optional parameter   
        static void Add(int a, int b, int c = 0, int d = 0, int e = 1) {

        }

        // overloading
        static void Add(int a) {
            a++;
        }

        static void Add(int a, int b) {
            int temp = a+b;
        }
    }
}
