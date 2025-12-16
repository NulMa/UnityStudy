using System.Diagnostics.Contracts;
using System.Text;

namespace ListPrac
{
    internal class Program
    {
        static void Main()
        {

            //List<int> myList = new List<int>() { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            //foreach (int item in myList)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n\n");
            //for (int i = 0; i < 25; i += 3)
            //{
            //    Console.Write($"{i}'s LowerBound is : ");
            //    LowerBound(myList, i);
            //    Console.WriteLine();
            //}

            BaekJoon10816();
        }





        static void BaekJoon10816()
        {
            int totalCard = int.Parse(Console.ReadLine());
            List<int> cards = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));


            int targetCard = int.Parse(Console.ReadLine());
            List<int> targets = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            List<int> result = new List<int>();

            StringBuilder stringBuilder = new StringBuilder();

            foreach (int target in targets)
            {
                int count = 0;
                foreach (int card in cards)
                {
                    if (card == target)
                    {
                        count++;
                    }
                }
                result.Add(count);
            }

            foreach (int item in result)
            {
                stringBuilder.Append(item + " ");
            }
            Console.WriteLine(stringBuilder.ToString().Trim());
        }
    }
}

        /// <summary>
        /// find out first value what is equal or greater than key in list      //list에서 key값과 같거나 큰 첫번째 값을 찾는다.
        /// </summary>
        /// <returns> value of  </returns>      //요약의 조건에 맞는 값을 찾았으면 그 값을, 못찾았다면 null을 리턴
        /// 
        //static void LowerBound(List<int> list, int key)
        //{
        //    int startIndex = 0;
        //    int endIndex = list.Count;

        //    while (startIndex < endIndex)
        //    {
        //        int middleIndex = (startIndex + endIndex) / 2;

        //        if (list[middleIndex] >= key)
        //        {
        //            if (middleIndex != 0 && list[middleIndex - 1] >= key)
        //            {
        //                endIndex = middleIndex;
        //            }
        //            else
        //            {
        //                Console.WriteLine(list[middleIndex]);
        //                return;
        //            }
        //        }
        //        else
        //        {
        //            startIndex = middleIndex + 1;
        //        }
        //    }
        //    if (startIndex >= endIndex) Console.WriteLine("None");
        //}

        /// <summary>
        /// Binary Search Algorithm                                 //이진 탐색 알고리즘, list에서 key값을 찾는다.
        /// </summary>
        /// <param name="list"> total values </param>               // 전체 값을 담은 리스트
        /// <param name="key"> value of need find out </param>      // 찾아야 할 값
        /// <returns> found key in list </returns>                  // key값을 찾았는가 못찾았는가
        /// <remarks> list is always sorted by Ascending </remarks> // list는 항상 오름차순으로 정렬되어 있다.
        //static bool BinarySearch(List<int> list, int key)
        //{
        //    int s = 0;
        //    int e = list.Count;

        //    while (s < e)
        //    {
        //        int m = (s + e) / 2;
        //        if (list[m] == key)
        //        {
        //            return true;
        //        }
        //        else if (list[m] < key)
        //        {
        //            s = m + 1;
        //        }
        //        else
        //        {
        //            e = m;
        //        }
        //    }
        //    return false;
        //}
//    }
//}


//====================================================================================================================================
        //static void Main()
        //{
        //    // 입력: 문자열을 입력받아 연결 리스트에 저장한다.
        //    string input = Console.ReadLine();
        //    LinkedList<char> container = new(input);

        //    int M = int.Parse(Console.ReadLine());
        //    int count = 0;

        //    // 처리: 명령어에 따라 문자열을 편집한다.
        //    // ㄴ 연결 리스트를 어떻게 조작할 것이냐? => container를 조작한다.
        //    // ㄴ 커서 개념을 구현해야 한다. => 커서는 container 내부 데이터를 표현해야하므로 LinkedListNode다.
        //    LinkedListNode<char> cursor = container.Last;

        //    char ch = 'x';
        //    cursor = container.AddAfter(cursor, ch);

        //    while (count < M)
        //    {   
        //        string? order = Console.ReadLine();

        //        if(order.Length > 1)
        //        {
        //            ch = order[2];                  //pick character
        //            order = order[0].ToString();    //pick orderCommand
        //        }
        //        else
        //        {
        //            ch = 'x'; //dummy
        //        }


        //        if(cursor != null)
        //        {
        //            switch (order)
        //            {
        //                case "L":
        //                    if (cursor != container.Last) cursor = cursor.Previous;
        //                    break;

        //                case "D":
        //                    if (cursor != container.First) cursor = cursor.Next;
        //                    break;

        //                case "B":
        //                    if (cursor.Previous != null) container.Remove(cursor.Previous);
        //                    break;

        //                case "P":
        //                    container.AddAfter(cursor, ch);
        //                    break;
        //            }
        //        }


        //        Console.WriteLine("ch = " + ch);
        //        foreach (char item in container)
        //        {
        //            Console.Write(item);
        //        }


        //        count++;
        //    }

//====================================================================================================================================

            // 커서: 에디터의 편집이 일어나는 위치

            // 명령어
            // ㄴ P ?: 커서 왼쪽에 문자를 삽입한다. => AddAfter() 호출 후, 커서 갱신

            // P ?: 커서 왼쪽에 ? 문자를 삽입한다. => container에 삽입한다.
            // ㄴ AddAfter(), AddBefore(),  
            // ㄴ LinkedListNode 타입의 객체가 필요하다. => 커서의 타입은 LinkedListNode로 나타낼 수 있겠구나.

        //    foreach (char item in container)
        //    {
        //        Console.Write(item);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    List<char> myList = new List<char>();
        //    string? input = Console.ReadLine();                     //input initial string
        //    int maxCount = int.Parse(Console.ReadLine());         //input Count of orders
        //    int curCount = 0;

        //    myList.AddRange(input);

        //    int curCursor;
        //    curCursor = myList.Count;
        //    while (curCount < maxCount)
        //    {
        //        string? inputOrder = Console.ReadLine();
        //        char orderChar;
        //        char[] orders = inputOrder.ToCharArray();

        //        int num = 0;

        //        if (inputOrder.Length > 1)
        //        {
        //            inputOrder = orders[0].ToString();
        //            orderChar = orders[2];
        //        }
        //        else
        //        {
        //            orderChar = ' ';
        //        }



        //        switch (inputOrder)
        //        {
        //            case "L":
        //                if (curCursor > 0) curCursor--;
        //                break;

        //            case "D":
        //                if(curCursor < myList.Count) curCursor++;
        //                break;

        //            case "B":
        //                if (curCursor > 0)
        //                {
        //                    myList.RemoveAt(curCursor-1);
        //                    curCursor--;
        //                }

        //                break;

        //            case "P":
        //                //Console.WriteLine("CC :" + curCursor + "/ oC :" + orderChar);

        //                myList.Insert(curCursor, orderChar);
        //                curCursor++;
        //                break;
        //        }

        //        //foreach (char item in myList)
        //        //{
        //        //    if(num == curCursor) Console.Write($"^");
        //        //    Console.Write($"{item}");
        //        //    num++;
        //        //}
        //        //Console.WriteLine();


        //        curCount++;
        //    }

        //    string result = string.Join("", myList);
        //    Console.WriteLine(result);
        //}

