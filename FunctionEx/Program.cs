namespace FunctionEx {
    internal class Program {
        static void Output(int fnA, int fnB) {
            Console.WriteLine(fnA + fnB);
        }

        static int Test(int  fnA) {
            return fnA + 1;
        }
        
        static void Main(string[] args) {
            int a = 10;
            int b = 20;

            Output(a, b);
            Test(a);
        }
    }
}
