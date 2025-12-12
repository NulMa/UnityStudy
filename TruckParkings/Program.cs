namespace TruckParkings {
    internal class Program {
        static void Main(string[] args)
        {
            string inputSDT = Console.ReadLine();
            string[] strSDT = inputSDT.Split(' ');

            string firstTruck = Console.ReadLine();
            var firstTruckParts = firstTruck.Split(' ');
            int firstTruckArrival = int.Parse(firstTruckParts[0]);

            Console.WriteLine();


        }
    }
}
