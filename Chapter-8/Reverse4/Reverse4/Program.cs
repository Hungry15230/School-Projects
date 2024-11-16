namespace Reverse4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 3;
            int secondInt = 6;
            int thirdInt = 10;
            int fourthInt = 14;
            Console.WriteLine($"{firstInt}, {secondInt}, {thirdInt}, {fourthInt}");
            Reverse(ref firstInt, ref secondInt, ref thirdInt, ref fourthInt);
            Console.WriteLine($"{firstInt}, {secondInt}, {thirdInt}, {fourthInt}");
        }

        private static void Reverse(ref int first, ref int second, ref int third, ref int fourth)
        {
            (fourth, first) = (first, fourth);
            (third, second) = (second, third);
        }
    }
}
