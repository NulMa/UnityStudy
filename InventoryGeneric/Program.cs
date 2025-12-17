namespace InventoryGeneric
{
    class Inventory<T>
    {
        private T[] items;
        private int count;

        public Inventory()
        {
            items = new T[4];
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                T[] newArray = new T[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
            }

            items[count] = item;
            count++;
        }

        public T Get(int index) => items[index];

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory<int> intInventory = new Inventory<int>();
            intInventory.Add(10);
            intInventory.Add(20);
            Console.WriteLine($"Count: Int = {intInventory.Count()}");
            Console.WriteLine($"Item: Int[1] = {intInventory.Get(1)}");

//===============================================================================

            Inventory<string> stringInventory = new Inventory<string>();
            stringInventory.Add("Sword");
            stringInventory.Add("Potion");
            Console.WriteLine($"Count: String = {stringInventory.Count()}");
            Console.WriteLine($"Item: String[0] = {stringInventory.Get(0)}");
        }
    }
}
