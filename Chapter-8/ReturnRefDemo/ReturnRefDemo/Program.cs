namespace ReturnRefDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int itemToFind;
            int x;
            int[] items = { 123, 241, 375, 410, 555 };
            Console.WriteLine("Before replacement: ");
            for (x = 0; x < items.Length; ++x)
            {
                Console.Write(" " + items[x]);
            }
            Console.Write("\nEnter the value to find: ");
            itemToFind = Convert.ToInt32(Console.ReadLine());
            ref int soldItem = ref FindItem(itemToFind, items);
            soldItem = 0;
            Console.WriteLine("After replacement: ");
            for (x = 0; x < items.Length; ++x)
            {
                Console.Write(" " + items[x]);
            }
            Console.WriteLine();
        }
        public static ref int FindItem(int findValue, int[] elements)
        {
            int x;
            int position = -1;
            for (x = 0; x < elements.Length; ++x)
            {
                if (findValue == elements[x])
                    position = x;
            }
            return ref elements[position];
        }
    }
}