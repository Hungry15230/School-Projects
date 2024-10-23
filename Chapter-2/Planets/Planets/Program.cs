using System;

namespace Planets
{
    class Program
    {
        enum Planets
        {
            MERCURY=1, VENUS, EARTH, MARS, JUPITER, SATURN, URANUS, NEPTUNE
        }
        static void Main(string[] args)
        {
            Console.Write("Desired planet number: ");
            int planetNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"The planet in that position is: {(Planets)planetNum}");
        }
    }
}
