namespace GuessingGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGen = new Random();
            int randomNumber = randomNumberGen.Next(1, 11);
            while (true)
            {
                Console.Write("Enter a number 1-11: ");
                string userInput = Console.ReadLine();
                int userNumber = Convert.ToInt16(userInput);

                if (randomNumber == userNumber)
                {
                    Console.WriteLine("Correct number guessed.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect number guessed.");
                }
            }
        }
    }
}