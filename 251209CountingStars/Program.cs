namespace _251209CountingStars {
    internal class Program
    {
        static void Main(string[] args) {
            int[] count = new int[26];
            string answer = "";
            string str = Console.ReadLine();
            Console.WriteLine(str);

            foreach (char c in str) {
                for(int i = 0; i < 27; i++) {
                    if ((int)c == 97+i)
                        count[i]++;
                }
            }
            foreach (int i in count) {
                answer += i + " ";
            }
            answer = answer.TrimEnd();
            Console.WriteLine(answer);   
        }
    }
}