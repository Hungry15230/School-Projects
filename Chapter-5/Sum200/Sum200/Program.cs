namespace Sum200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int j = 0; j <= 100; j++)
            {
                total += j;
            }
            Console.WriteLine(total);
            for (int j = 100; j <= 200; j++)
            {
                total += j;
            }
            Console.WriteLine(total);
        }
    }
}
