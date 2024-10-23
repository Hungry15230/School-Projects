using System;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken1EggsPerMonth = 30;
            int chicken2EggsPerMonth = 27;
            int chicken3EggsPerMonth = 38;
            int chicken4EggsPerMonth = 32;

            int sumOfEggs = chicken1EggsPerMonth + chicken2EggsPerMonth + chicken3EggsPerMonth + chicken3EggsPerMonth;
            int dozensOfEggs = sumOfEggs / 12;
            int singleEggs = sumOfEggs % 12;

            Console.WriteLine($"{sumOfEggs} eggs per month is {dozensOfEggs} dozen and {singleEggs} eggs per month.");
        }
    }
}
