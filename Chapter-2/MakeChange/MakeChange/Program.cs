using System;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int dollars = 113;
            int startingDollars = dollars;
            int twenties = dollars / 20;
            dollars = dollars % 20;
            int tens = dollars / 10;
            dollars = dollars % 10;
            int fives = dollars / 5;
            dollars = dollars % 5;
            int ones = dollars / 1;
            dollars = dollars % 1;
            Console.WriteLine($"{startingDollars} is worth {twenties} twenties, {tens} tens, {fives} fives, and {ones} ones.");
        }
    }
}
