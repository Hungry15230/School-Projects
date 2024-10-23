using static System.Console;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            int min = 1;
            int max = 11;
            randomNumber = ranNumberGenerator.Next(min, max);

            Write("Guess a number: ");
            int number = Convert.ToInt16(ReadLine());
            if (number == randomNumber)
            {
                WriteLine("Correct.");
            }
            else if (number < randomNumber)
            {
                WriteLine("Too low.");
            }
            else if (number > randomNumber)
            {
                WriteLine("Too high.");
            }
            WriteLine(randomNumber);

        }
    }
}
