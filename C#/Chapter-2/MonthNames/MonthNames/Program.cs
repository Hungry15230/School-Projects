using System;

namespace MonthNames
{
    class Program
    {
        enum Month
        {
            JANUARY=1, FEBUARY, MARCH, APRIL,
            MAY, JUNE, JULY, AUGUST, SEPTEMBER,
            OCTOBER, NOVEMBER, DECEMBER
        }

        static void Main(string[] args)
        {
            Console.Write("Month number: ");
            int monthNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"That month is {(Month)monthNum}.");
        }
    }
}
