namespace DeligatePrac
{
    internal class Program
    {
        delegate void SortFunc(List<int> list);

        static List<int> Sort(SortFunc sortFunc)
        {
            List<int> ints = new List<int>();
            sortFunc(ints);

            return new List<int>();
        }
        static int Test()
        {
            Console.WriteLine("Button Clicked");
            return 0;
        }

        static void Main()
        {
            
        }
    }
}
