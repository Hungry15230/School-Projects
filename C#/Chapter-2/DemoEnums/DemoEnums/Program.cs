using System;

namespace DemoEnums
{
    class Program
    {
        enum DayOfWeek
        {
            SUNDAY = 1, MONDAY, TUESDAY, WEDNESDAY,
            THURSDAY, FRIDAY, SATURDAY
        }
        static void Main(string[] args)
        {
            int shipDay;
            DayOfWeek deliverDay;
            Console.WriteLine();
            shipDay = (int)DayOfWeek.THURSDAY;
            deliverDay = (DayOfWeek)shipDay;
            Console.WriteLine(shipDay);
            Console.WriteLine(deliverDay);
        }
    }
}
