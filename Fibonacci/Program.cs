using System.Numerics;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] primalList = new BigInteger[1001];
            int input = int.Parse(Console.ReadLine());
            if (input < primalList.Length) Console.WriteLine(Fibonacci(input, primalList));
        }

        static BigInteger Fibonacci(int n, BigInteger[] fiboArr){
            if (fiboArr[n] != 0) return fiboArr[n];
            if (n == 0) return 0;
            if (n == 1) return 1;

            return fiboArr[n] = Fibonacci(n - 1, fiboArr) + Fibonacci(n - 2, fiboArr);
        }
    }
}ㅋ