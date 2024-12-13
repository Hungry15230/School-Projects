namespace Averages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayAverage(1);
            Console.WriteLine("-----");
            DisplayAverage(1, 2);
            Console.WriteLine("-----");
            DisplayAverage(1, 2, 3);
            Console.WriteLine("-----");
            DisplayAverage([1, 2, 3, 4, 5]);
        }
        static void DisplayAverage(params int[] args)
        {
            foreach (int i in args)
            {
                Console.WriteLine(i);
            }
        }
    }
}