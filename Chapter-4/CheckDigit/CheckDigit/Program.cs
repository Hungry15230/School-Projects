using static System.Console;

namespace CheckDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string accountNumber;
            bool accountNumberIsValid;

            Write("Account Number: ");
            accountNumber = ReadLine();
            accountNumberIsValid = 0 == Convert.ToInt16(accountNumber[..3]) % 7;
            WriteLine(accountNumberIsValid);
            
        }
    }
}
