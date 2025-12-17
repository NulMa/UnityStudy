namespace _251217Prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.RemoveAt(0);

        }
    }

    class MyList
    {
        private int capacity { get { return array.Length; } }
        private int count;
        private int[] array;

        public MyList()
        {
            array = new int[4];
        }
    
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void Add(int item)
        {
            if (count == capacity)
            {
                int[] newArray = new int[capacity * 2];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }

            array[count] = item;
            count++;

            PrintList();
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            count--;
            array[count] = 0;

            PrintList();
        }

        private void PrintList()
        {
            Console.Write("Current List : ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
