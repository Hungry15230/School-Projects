namespace FlexibleArrayMethod
{
    internal class Program
    {
        static void DisplayArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5};
            int[] array2 = { 6, 7, 8 };
            int[] array3 = { 10, 11, 12, 13, 14, 15};
            DisplayArray(array1);
            DisplayArray(array2);
            DisplayArray(array3);
        }
    }
}