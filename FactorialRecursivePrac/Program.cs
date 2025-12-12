namespace FactorialRecursivePrac {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));
        }

        public static int Factorial(int n) {
            if (n == 0) return 1; // 0! = 1
            return n * Factorial(n - 1);
        }
    }
}

/*
 
 Factorial(10)
    if (10 == 0) return 1;          => not returned
    return 10 * Factorial(10 - 1);                                                          = 10 * 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1 * 1

        if (9 == 0) return 1;       => not returned
        return 9 * Factorial(9 - 1);                                                        = 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1 * 1

            if (8 == 0) return 1;   => not returned
            return 8 * Factorial(8 - 1);                                                    = 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1 * 1

                if (7 == 0) return 1;   => not returned
                return 7 * Factorial(7 - 1);                                                = 7 * 6 * 5 * 4 * 3 * 2 * 1 * 1

                    if (6 == 0) return 1;   => not returned
                    return 6 * Factorial(6 - 1);                                            = 6 * 5 * 4 * 3 * 2 * 1 * 1

                        if (5 == 0) return 1;   => not returned
                        return 5 * Factorial(5 - 1);                                        = 5 * 4 * 3 * 2 * 1 * 1

                            if (4 == 0) return 1;   => not returned
                            return 4 * Factorial(4 - 1);                                    = 4 * 3 * 2 * 1 * 1

                                if (3 == 0) return 1;   => not returned
                                return 3 * Factorial(3 - 1);                                = 3 * 2 * 1 * 1

                                    if (2 == 0) return 1;   => not returned
                                    return 2 * Factorial(2 - 1);                            = 2 * 1 * 1

                                        if (1 == 0) return 1;   => not returned
                                        return 1 * Factorial(1 - 1);                        = 1 * 1
    
                                            if (0 == 0) return 1;   => returned 1           = 1
 
 
 
 
 
 
 
 */