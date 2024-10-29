namespace GuessingGame3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGen = new Random();
            int randomNumber = randomNumberGen.Next(1, 11);
            int obviouslyLowerThan = 11;
            int obviouslyHigherThan = 0;
            while (true)
            {
                Console.Write("Enter a number 1-11: ");
                string userInput = Console.ReadLine() ?? "";
                int userNumber = Convert.ToInt16(userInput);
                if (randomNumber == userNumber)
                {
                    Console.WriteLine("Correct number guessed.");
                    break;
                }
                else
                {
                    if (userNumber < randomNumber)
                    {
                        if (userNumber <= obviouslyHigherThan)
                        {
                            Console.WriteLine("Idiot, I already told you that's too low.");
                        } else
                        {
                            Console.WriteLine("Too low.");
                            obviouslyHigherThan = userNumber;
                        }
                    }
                    else if (userNumber > randomNumber)
                    {
                        if (userNumber > obviouslyLowerThan)
                        {
                            Console.WriteLine("Idiot, I already told you that's too high.");
                        } else
                        {
                            Console.WriteLine("Too high");
                            obviouslyLowerThan = userNumber;
                        }
                    }
                }
            }
        }
    }
}