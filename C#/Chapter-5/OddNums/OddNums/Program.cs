﻿namespace OddNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1) { Console.WriteLine(i); }
            }
        }
    }
}
