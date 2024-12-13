using System;

namespace MoveEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            int PER_MOVE = 200;
            int PER_HOUR = 150;
            int PER_MILE = 2;

            Console.Write("How many hours will the trip take? ");
            double hoursMoving = Convert.ToDouble(Console.ReadLine());
            Console.Write("How many miles will the trip be? ");
            double milesMoving = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Total moving fee: {PER_MOVE+(PER_HOUR*hoursMoving)+(PER_MILE*milesMoving):C}");
        }
    }
}
