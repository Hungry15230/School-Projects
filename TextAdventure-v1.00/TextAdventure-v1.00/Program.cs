namespace TextAdventure_v1._00
{
    internal class Program
    {
        static bool ParseAndExecute(string input)
        {
            char[] delimiters = { ' ', '\n' };
            string[] tokens = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            string? verb = tokens.Length > 0 ? tokens[0] : null;
            string? noun = tokens.Length > 1 ? tokens[1] : null;
            if (verb != null)
            {
                verb = verb.ToLower();
                if (String.Compare(verb, "quit") == 0)
                {
                    return false;
                }
                else if (String.Compare(verb, "look") == 0)
                {
                    Console.WriteLine("It is very dark in here.");
                }
                else if (String.Compare(verb, "go") == 0)
                {
                    Console.WriteLine("It's too dark to go anywhere.");
                }
                else
                {
                    Console.WriteLine("I don't know how to '{0}'.", verb);
                }
            }
            return true;
        }

        static bool GetInput(out string input)
        {
            Console.Write("> ");
            input = Console.ReadLine() ?? "";
            return input != null && input.Length > 0;
        }

        static void GameLoop()
        {
            string input;
            while (GetInput(out input) && ParseAndExecute(input)) { }
        }
        static void Main(string[] args)
        {
            // Greeting
            Console.WriteLine("Welcome to Little Cave Adventure.");
            while (true)
            {
                // Main Loop
                GameLoop();
                // Exit handling
                Console.WriteLine("You failed. Play again? (y/n)");
                string userInput = Console.ReadLine() ?? "";
                if (userInput == "y") { }
                else { break; }
            }
            Console.WriteLine("Bye!");
        }
    }
}