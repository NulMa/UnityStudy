namespace Cumulative_sum {
    internal class Program {
        static void Main(string[] args) {
            int input = 10;

            int half = input / 2;
            int remain = input % 2;
            int answer = 0;

            for(int i = 0; i < half; i++) {
                answer += (1 + input);
            }
            Console.WriteLine("Cumulative Sum is : " + answer);
        }
    }
}
