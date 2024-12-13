namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            int min = 1;
            int max = 3;
            string compChoice;
            string userChoice;
            randomNumber = ranNumberGenerator.Next(min, max);
            switch (randomNumber)
            {
                case 1: compChoice = "Rock"; break;
                case 2: compChoice = "Paper"; break;
                case 3: compChoice = "Scissors"; break;
                default: compChoice = "Error"; break;
            }
            Console.Write("Your choice (r, p, s): ");
            userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "r": userChoice = "Rock"; break;
                case "p": userChoice = "Paper"; break;
                case "s": userChoice = "Scissors"; break;
                default: userChoice = "Error"; break;
            }
            Console.WriteLine("Computer choice: " + compChoice);
            if (compChoice == "Error" || userChoice == "Error") { Console.WriteLine("Error"); }
            else if (compChoice == userChoice) { Console.WriteLine("Tie."); }
            else if (compChoice == "Error" || userChoice == "Error") { Console.WriteLine("Error"); }
            else if (compChoice == "Rock" && userChoice == "Paper") { Console.WriteLine("Computer Wins."); }
            else if (compChoice == "Rock" && userChoice == "Scissors") { Console.WriteLine("You Win."); }
            else if (compChoice == "Paper" && userChoice == "Rock") { Console.WriteLine("Computer Wins."); }
            else if (compChoice == "Paper" && userChoice == "Scissors") { Console.WriteLine("You Win."); }
            else if (compChoice == "Scissors" && userChoice == "Paper") { Console.WriteLine("Computer Wins."); }
            else if (compChoice == "Scissors" && userChoice == "Rock") { Console.WriteLine("You Win."); }
        }
    }
}
