namespace GuessAWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string currentWord;
            string knownLetters = "";
            string[] wordOptions = { "programming", "marathon", "magical", "hypothalamus", "mordor", "coconut", "basalt", "volcano" };
            List<int> indexesOfLetters = new List<int>();
            currentWord = wordOptions[random.Next(0, 8)];
            for (int i = 0; i < currentWord.Length; i++) { knownLetters += "_"; }
            while (true)
            {
                Console.Write($"Word to guess: ");
                Console.WriteLine(knownLetters);
                Console.Write("Guess a letter: ");
                char guessedLetter = Convert.ToChar(Console.ReadLine() ?? "");
                if (currentWord.Contains(guessedLetter))
                {
                    indexesOfLetters.Clear();
                    for (int i = 0; i < currentWord.Length; i++)
                    {
                        if (currentWord[i] == guessedLetter) { indexesOfLetters.Add(i); }
                    }
                    for (int i = 0; i < indexesOfLetters.Count; i++)
                    {
                        knownLetters = knownLetters.Remove(indexesOfLetters[i], 1).Insert(indexesOfLetters[i], Convert.ToString(guessedLetter));
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Letter");
                }
                if (!knownLetters.Contains("_")) { break; }
            }
            Console.WriteLine(knownLetters);
            Console.WriteLine("Congrats!");
        }
    }
}