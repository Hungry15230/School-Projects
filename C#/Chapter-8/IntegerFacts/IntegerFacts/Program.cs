namespace IntegerFacts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[10];
            int highestValue;
            int lowestValue;
            int sum;
            double average;
            FillArray(ref ints);
            GetArrayStats(out highestValue, out lowestValue, out sum, out average, ints);
            Console.WriteLine("Highest Value:    " + highestValue);
            Console.WriteLine("Lowest Value:     " + lowestValue);
            Console.WriteLine("Sum of array:     " + sum);
            Console.WriteLine("Average of array: " + average);
        }
        private static void FillArray(ref int[] ints)
        {
            bool fillArray = true;
            Console.WriteLine("Enter 'e' to stop filling array.");
            for (int i = 0; i < ints.Length && fillArray; i++)
            {
                Console.Write($"Value to put in array position {i}: ");
                string input = Console.ReadLine() ?? "".ToLower();
                if (input == "e") { fillArray = false; }
                while (!int.TryParse(input, out ints[i]) && fillArray)
                {
                    Console.WriteLine("Invalid, try again.");
                    Console.Write($"Value to put in array position {i}: ");
                    input = Console.ReadLine() ?? "".ToLower();
                    if (input == "e") { fillArray = false; }
                }
            }
        }
        private static void GetArrayStats(out int highest, out int lowest, out int sum, out double avg, int[] ints)
        {
            highest = ints.Max();
            lowest = ints.Min();
            sum = ints.Sum();
            avg = ints.Average();
        }
    }
}
