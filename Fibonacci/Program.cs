using System.Numerics;

namespace Fibonacci {
    internal class Program {
        static void Main(string[] args) {
            BigInteger[] primalList = new BigInteger[1001];
            int input = int.Parse(Console.ReadLine());

            if (input < primalList.Length) Console.WriteLine(Fibonacci(input, primalList));
        }

        static BigInteger Fibonacci(int n, BigInteger[] fiboArr) {
            if (fiboArr[n] != 0) return fiboArr[n];
            if (n == 0) return 0;
            if (n == 1) return 1;

            return fiboArr[n] = Fibonacci(n - 1, fiboArr) + Fibonacci(n - 2, fiboArr);
        }
    }
}

/*
         static void Main(string[] args) {
            long[] primalList = new long[101];
            int input = int.Parse(Console.ReadLine());

            if(input < primalList.Length)Console.WriteLine(Fibonacci(input, primalList));
        }

        static long Fibonacci(int n, long[] fiboList) {
            if (fiboList[n] != 0) return fiboList[n];
            if (n == 0) return 0;
            if (n == 1) return 1;

            return fiboList[n] = Fibonacci(n - 1, fiboList) + Fibonacci(n - 2, fiboList);
        }
    }
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */



/*
        static int Fibonacci(int 5)
        {
            if (5 == 0) return 0;
            if (5 == 1) return 1;
            Fibonacci(5 - 1)
                if (4 == 0) return 0;
                if (4 == 1) return 1;
                Fibonacci(4 - 1)
                    if (3 == 0) return 0;
                    if (3 == 1) return 1;
                    Fibonacci(3 - 1)
                        if (2 == 0)
                        if (2 == 1)
                        Fibonacci(2 - 1)    => returns 1
                    Fibonacci(3 - 2)        => returns 1
                Fibonacci(4 - 2)
                    if (2 == 0) return 0;
                    if (2 == 1) return 1;
                    Fibonacci(2 - 1)        => returns 1
                    Fibonacci(2 - 2)        => returns 0
            Fibonacci(5 - 2);
                if (3 == 0) return 0;
                if (3 == 1) return 1;
                Fibonacci(3 - 1)
                    if (3 == 0) return 0;
                    if (3 == 1) return 1;
                    Fibonacci(2 - 1)        => returns 1
                    Fibonacci(2 - 2)        => returns 0
                Fibonacci(3 - 2)
                    if (1 == 0) return 0;
                    if (1 == 1) return 1;
                    Fibonacci(1 - 1)        => returns 0    
                    Fibonacci(1 - 2)        => not called


                                            => sum of returns = 5
            }
        }
 
 */
