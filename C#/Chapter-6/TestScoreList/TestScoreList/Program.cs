﻿namespace TestScoreList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = new int[8];
            int totalScores = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
                Console.Write($"Enter score for test {i+1}: ");
                testScores[i] = Convert.ToInt16(Console.ReadLine());
                totalScores += testScores[i];
            }
            Console.WriteLine("--------------------------");
            double averageScore = totalScores / testScores.Length;
            foreach (var score in testScores)
            {
                Console.WriteLine($"{score} is {Math.Abs(score-averageScore)} away from the average score, {averageScore}");
            }
        }
    }
}
