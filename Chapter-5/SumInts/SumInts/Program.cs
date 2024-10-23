namespace SumInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 0;
            while (number != 999)
            {
                Console.Write("Enter a number: ");
                sum += number;
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Sum of numbers entered, not including 999: {sum}");
        }
    }
}
