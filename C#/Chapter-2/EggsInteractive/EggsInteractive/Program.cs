using System;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chicken 1 eggs per month: ");
            double chicken1EggsPerMonth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chicken 2 eggs per month: ");
            double chicken2EggsPerMonth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chicken 3 eggs per month: ");
            double chicken3EggsPerMonth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chicken 4 eggs per month: ");
            double chicken4EggsPerMonth = Convert.ToDouble(Console.ReadLine());

            double sumOfEggs = chicken1EggsPerMonth + chicken2EggsPerMonth + chicken3EggsPerMonth + chicken4EggsPerMonth;
            double dozensOfEggs = sumOfEggs / 12;
            double singleEggs = sumOfEggs % 12;

            Console.WriteLine($"{sumOfEggs} eggs per month is {dozensOfEggs} dozen and {singleEggs} eggs per month.");
        }
    }
}
