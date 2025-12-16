using System.Linq;
using System.Xml;
namespace CableCut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CableCut();
        }

        static void CableCut()
        {
            string[] input = Console.ReadLine().Split();
            int initialCableCount = int.Parse(input[0]);
            int targetCableCount = int.Parse(input[1]);

            //cables quantity
            long[] cablesArr = new long[initialCableCount];

            //longest cable length
            long maxCable = 0;


            for (int i = 0; i < initialCableCount; i++)
            {
                cablesArr[i] = long.Parse(Console.ReadLine());

                //find longest cable
                if (cablesArr[i] > maxCable) maxCable = cablesArr[i];                       
            }

            //minimum length of cable to cut
            long low = 1;                                                                   

            //maximum length of cable to cut
            long high = maxCable;
            long result = 0;

            while (low <= high)
            {   
                //current length to test
                long mid = (low + high) / 2;
                long count = 0;

                foreach (long cable in cablesArr)
                {
                    //count how many cables can be made with 'mid' length
                    count += cable / mid;
                }

                //if we can make enough cables with 'mid' length
                if (count >= targetCableCount)
                {
                    //record 'mid' as a possible answer
                    result = mid;            

                    //try to find a longer length
                    low = mid + 1;                                                          
                }

                //if we cannot make enough cables with 'mid' length
                else
                {
                    //try to find a shorter length
                    high = mid - 1;                                                         
                }
            }

            Console.WriteLine(result);
        }
    }
}
