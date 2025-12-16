namespace Bj12015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int count = 0;
            int max = 0;

            foreach (int item in arr)
            {
                if (item >= max)
                {
                    max = item;
                    count++;
                    max = item;
                }
            }

            Console.WriteLine(count);
        }
    }
}
