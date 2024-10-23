using static System.Console;

namespace CheckMonth2
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
            int birthMonth;
            int birthDay;
            int janDays = 31;
            int febDays = 29;
            int marDays = 31;
            int aprDays = 30;
            int mayDays = 31;
            int junDays = 30;
            int julDays = 31;
            int augDays = 31;
            int sepDays = 30;
            int octDays = 31;
            int novDays = 30;
            int decDays = 31;
            Write("Birth Month: ");
            birthMonth = Convert.ToInt16(ReadLine());
            Write("Birth Day: ");
            birthDay = Convert.ToInt16(ReadLine());
            if (birthMonth <= 12 && birthMonth >= 1)
            {
                Write((Month)birthMonth + " ");
                switch ((Month)birthMonth)
                {
                    case Month.JANUARY: if (birthDay <= janDays) { WriteLine(birthDay); } break;
                    case Month.FEBUARY: if (birthDay <= febDays) { WriteLine(birthDay); } break;
                    case Month.MARCH: if (birthDay <= marDays) { WriteLine(birthDay); } break;
                    case Month.APRIL: if (birthDay <= aprDays) { WriteLine(birthDay); } break;
                    case Month.MAY: if (birthDay <= mayDays) { WriteLine(birthDay); } break;
                    case Month.JUNE: if (birthDay <= junDays) { WriteLine(birthDay); } break;
                    case Month.JULY: if (birthDay <= julDays) { WriteLine(birthDay); } break;
                    case Month.AUGUST: if (birthDay <= augDays) { WriteLine(birthDay); } break;
                    case Month.SEPTEMBER: if (birthDay <= sepDays) { WriteLine(birthDay); } break;
                    case Month.OCTOBER: if (birthDay <= octDays) { WriteLine(birthDay); } break;
                    case Month.NOVEMBER: if (birthDay <= novDays) { WriteLine(birthDay); } break;
                    case Month.DECEMBER: if (birthDay <= decDays) { WriteLine(birthDay); } break;
                    default: WriteLine("Invalid Day"); break;
                }
            }
            else { WriteLine("Invalid month."); }
        }
    }
}
