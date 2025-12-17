namespace _251217Prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntCounts(10);
            CharCounts('j');

            static void IntCounts(int count)
            {
                MyList<int> intlist = new MyList<int>();
                for (int i = 0; i < count; i++)
                {
                    intlist.Add(i);
                }

                for (int i = 0; i < count; i++)
                {
                    intlist.RemoveLast();
                }
            }

            static void CharCounts(char a)
            {
                MyList<char> charlist = new MyList<char>();
                for (char c = 'a'; c <= a; c++)
                {
                    charlist.Add(c);
                }
                for (char c = 'a'; c <= a; c++)
                {
                    charlist.RemoveLast();
                }
            }


        }
    }

    class Test<T>
    {
        public T? unknown;
    }



    class MyList<T>
    {
        private int capacity { get { return array.Length; } }
        private int count;
        private T[] array;

        public MyList()
        {
            array = new T[4];
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                T[] newArray = new T[capacity * 2];
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
            PrintList();
        }

        public void RemoveLast()
        {
            if (count > 0)
            {
                count--;
            }
            PrintList();
        }

        private void PrintList()
        {
            Console.Write("CL : ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
