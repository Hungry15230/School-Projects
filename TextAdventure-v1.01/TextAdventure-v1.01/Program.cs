namespace TextAdventure_v1._01
{
    public class Location
    {
        public string Description { get; set; }
        public string Tag { get; set; }
    }
    public class ParseAndExecute
    {
        private List<Location> locations = new List<Location> {
            new Location { Description = "an open field", Tag = "field" },
            new Location { Description = "a little cave", Tag = "cave" }
        };
        private int locationOfPlayer = 0;

        public bool Parse(string input)
        {
            char[] delimiters = { ' ', '\n' };
            string[] tokens = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            string? verb = tokens.Length > 0 ? tokens[0] : null;
            string? noun = tokens.Length > 1 ? tokens[1] : null;

            if (verb != null)
            {
                verb = verb.ToLower();
                if (string.Compare(verb, "quit") == 0)
                {
                    return false;
                }
                else if (string.Compare(verb, "look") == 0)
                {
                    ExecuteLook(noun);
                }
                else if (string.Compare(verb, "go") == 0)
                {
                    ExecuteGo(noun);
                }
                else
                {
                    Console.WriteLine("I don't know how to '{0}'.", verb);
                }
            }
            return true;
        }

        public void ExecuteLook(string noun)
        {
            if (!string.IsNullOrEmpty(noun) && noun.Equals("around", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"You are in {locations[locationOfPlayer].Description}.");
            }
            else
            {
                Console.WriteLine("I don't understand what you want to see.");
            }
        }

        public void ExecuteGo(string noun)
        {
            for (int i = 0; i < locations.Count; i++)
            {
                if (!string.IsNullOrEmpty(noun) && noun.Equals(locations[i].Tag, StringComparison.OrdinalIgnoreCase))
                {
                    if (i == locationOfPlayer)
                    {
                        Console.WriteLine("You can't get much closer than this.");
                    }
                    else
                    {
                        Console.WriteLine("OK.");
                        locationOfPlayer = i;
                        ExecuteLook("around");
                    }
                    return;
                }
            }
            Console.WriteLine("I don't understand where you want to go.");
        }
    }

    internal class Program
    {
        static bool GetInput(out string input)
        {
            Console.Write("> ");
            input = Console.ReadLine() ?? "";
            return input.Length > 0;
        }

        static void GameLoop(ParseAndExecute parser)
        {
            string input;
            while (GetInput(out input) && parser.Parse(input)) { }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Little Cave Adventure.");
            var parser = new ParseAndExecute(); // Create an instance of ParseAndExecute

            while (true)
            {
                GameLoop(parser); // Pass the instance to GameLoop

                Console.WriteLine("You failed. Play again? (y/n)");
                string userInput = Console.ReadLine() ?? "";
                if (userInput != "y") { break; }
            }
            Console.WriteLine("Bye!");
        }
    }
}
