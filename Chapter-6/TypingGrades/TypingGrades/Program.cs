namespace TypingGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] wordLowRanges = { 0, 16, 31, 51, 76 };
            char[] grades = { 'F', 'D', 'C', 'B', 'A' };
            Console.Write("Words per minute: ");
            int wordsPerMin = Convert.ToInt32(Console.ReadLine());
            int sub = wordLowRanges.Length - 1;
            while (sub >= 0 && wordsPerMin < wordLowRanges[sub]) --sub;
            Console.WriteLine($"Grade: {grades[sub]}");
        }
    }
}
