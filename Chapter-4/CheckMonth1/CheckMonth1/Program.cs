using static System.Console;

namespace CheckMonth1
{
    internal class Program
    {
        enum Month
        {
            JANUARY = 1, FEBUARY, MARCH, APRIL,
            MAY, JUNE, JULY, AUGUST, SEPTEMBER,
            OCTOBER, NOVEMBER, DECEMBER
        }
        static void Main(string[] args)
        {
            Write("Birth Month: ");
            int birthMonth = Convert.ToInt16(ReadLine());
            if (birthMonth <= 12 && birthMonth >= 1) { WriteLine((Month)birthMonth); }
            else { WriteLine("Invalid"); }
        }
    }
}
