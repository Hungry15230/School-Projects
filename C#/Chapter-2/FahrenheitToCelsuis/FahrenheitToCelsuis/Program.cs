using System;

namespace FahrenheitToCelsuis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperature in Fahrenheit: ");
            double tempInF = Convert.ToDouble(Console.ReadLine());
            double tempInC = (tempInF - 32)*0.5;
            Console.WriteLine($"Is equivalent to {tempInC:F1} celsius.");
        }
    }
}
