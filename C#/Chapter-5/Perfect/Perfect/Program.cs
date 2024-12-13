namespace Perfect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <= 100; j++)
            {
                int numToEval = j;
                int sum = 0;
                Console.WriteLine();
                for (int i = 1; i < (Convert.ToDouble(numToEval) / 2); i++)
                {
                    if (numToEval % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == numToEval)
                {
                    Console.WriteLine($"{numToEval} is a perfect number.");
                }

            }
        }
    }
}
