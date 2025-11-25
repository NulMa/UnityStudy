namespace Cumulative_sum {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Input Your Value : ");
            string userInput = Console.ReadLine();

            int input = int.Parse(userInput);
            int half = input / 2;
            int answer = 0;

            if(input % 2 == 0) {
                for (int i = 0; i < half; i++) {
                    answer += (1 + input);
                }
            }

            else {
                half = (input - 1) / 2; 
                for(int i = 0; i < half; i++) {
                    answer += (1 + input);
                }
                answer += (half + 1);
            }

             Console.WriteLine("Cumulative Sum is : " + answer);
        }
    }
}
