using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double CENTIMETERS_IN_INCH = 2.54;
            double inches = 34;
            Console.WriteLine($"{inches} inches is {inches*CENTIMETERS_IN_INCH} centimeters.");
        }
    }
}
