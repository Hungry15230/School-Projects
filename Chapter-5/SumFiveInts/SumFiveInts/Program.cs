namespace SumFiveInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                number += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"The sum of your sumbers is: {number}");
        }
    }
}
