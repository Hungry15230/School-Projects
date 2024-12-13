using System;

namespace InchesToCentimetersInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            double CENTIMETERS_IN_INCH = 2.54;
            double inches = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{inches} inches is {inches * CENTIMETERS_IN_INCH} centimeters.");
        }
    }
}
