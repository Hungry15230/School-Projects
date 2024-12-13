using System;

namespace TestsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Score 1: ");
            float score1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Test Score 2: ");
            float score2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Test Score 3: ");
            float score3 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Test Score 4: ");
            float score4 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Test Score 5: ");
            float score5 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Test Score 6: ");
            float score6 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Test Score 7: ");
            float score7 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Test Score 8: ");
            float score8 = Convert.ToInt16(Console.ReadLine());
            float averageScore = (score1 + score2 + score3 + score4 + score5 + score6 + score7 + score8)/8;
            Console.WriteLine($"{averageScore:F}");
        }
    }
}
