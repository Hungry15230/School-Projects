namespace MethodTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            DisplayReferenceParameter(ref x);
            Console.WriteLine($"In Main(), x is {x}");
        }

        private static void DisplayReferenceParameter(ref int number)
        {
            number = 888;
            Console.WriteLine($"In method, number is {number}");
        }
    }
}