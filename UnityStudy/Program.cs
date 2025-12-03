namespace UnityStudy
{
    public enum Season {
        Spring = 1,
        Summer,
        Autumn,
        Winter
    }
    internal class Program {
        static void Main(string[] args) {
            Season a = Season.Autumn;
            Console.WriteLine($"int val of {a} is {(int)a}");

            Season b = (Season)1;
            Console.WriteLine(b);

            Season c = 0;
            Console.WriteLine(c);
        }
    }
}
