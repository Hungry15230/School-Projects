using System;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 234;
            Console.WriteLine($"{minutes} minutes becomes {minutes/60} hours and {minutes%60} minutes.");
        }
    }
}
