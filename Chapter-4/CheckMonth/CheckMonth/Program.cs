using static System.Console;

enum Month
{
    JANUARY = 1, FEBUARY, MARCH, APRIL,
    MAY, JUNE, JULY, AUGUST, SEPTEMBER,
    OCTOBER, NOVEMBER, DECEMBER
}

Write("Birth Month: ");
int birthMonth = Convert.ToInt16(ReadLine());
if (birthMonth <= 12 && birthMonth >= 1) {}