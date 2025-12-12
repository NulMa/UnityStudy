namespace RecurPrac {
    internal class Program {
        static void Main(string[] args) {
            int num = 12;
            //for(int i = 1; i <= 10; i++) {
            //    Console.WriteLine(i);
            //}
            //RecurPrac(num);
            DecimalToBinary(num);


            /*
            12      /2  0
            6       /2  0
            3       /2  1
            1
            */
        }


    public static void DecimalToBinary(int num) {
            if (num == 0) return;

            DecimalToBinary(num / 2);
            Console.Write(num % 2);
        } 
    }

    /*      12(decimal) Convert To 1100(binary)
     *      
     *      12 % 2 = 0                  // 0
     *          6 % 2 = 0               // 0
     *              3 % 2 = 1           // 1
     *                  1 % 2 = 1       // 1
     *                  
     *      reverse  => 1100

        DecimalToBinary(12)                                 => Start Recursive Function

            DecimalToBinary(12 / 2);                        => recursive
                if (12 == 0) return;                        => not returned

                DecimalToBinary(6 / 2);                     => recursive
                    if(6 == 0) return;                      => not returned

                    DecimalToBinary(3 / 2)                  => recursive
                        if(3 == 0) return;                  => not returned

                        DecimalToBinary(1 / 2)              => recursive
                            if(1 == 0) return;              => not returned

                            DecimalToBinary(0 / 2);         => recursive
                                if(0 == 0) return;          => base case    //    Returns here

    =======================================================  Function Unwinding Here =======================================================
    
                            Console.Write(0 % 2);           => not called   //      Ignored
                        Console.Write(1 % 2);               => 1
                    Console.Write(3 % 2);                   => 1
                Console.Write(6 % 2);                       => 0
            Console.Write(12 % 2)                           => 0

     */
}
