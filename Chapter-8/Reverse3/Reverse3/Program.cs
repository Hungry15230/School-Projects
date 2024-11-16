namespace Reverse3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 3;
            int middleInt = 6;
            int lastInt = 10;
            Console.WriteLine($"{firstInt}, {middleInt}, {lastInt}");
            Reverse(ref firstInt, ref lastInt);
            Console.WriteLine($"{firstInt}, {middleInt}, {lastInt}");
        }

        private static void Reverse(ref int first, ref int last)
        {
            (last, first) = (first, last);
        }
    }
}
