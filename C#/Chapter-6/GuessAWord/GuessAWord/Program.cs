namespace GuessAWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string knownLetters = "";
            string[] wordOptions = { "programming", "marathon", "magical", "hypothalamus", "mordor", "coconut", "basalt", "volcano" };
            string currentWord = wordOptions[random.Next(wordOptions.Length)];
            for (int i = 0; i < currentWord.Length; i++) { knownLetters += "_"; }
            while (true)
            {
                Console.WriteLine($"Word to guess: {knownLetters}");
                Console.Write($"Guess a letter: ");
                char guessedLetter = Convert.ToChar(Console.ReadLine() ?? "");
                if (currentWord.Contains(guessedLetter))
                {
                    Console.WriteLine($"Word contains '{guessedLetter}'.");
                    for (int i = 0; i < currentWord.Length; i++)
                    {
                        if (currentWord[i] == guessedLetter)
                        {
                            knownLetters = knownLetters.Remove(i, 1).Insert(i, Convert.ToString(guessedLetter));
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Word does not contain '{guessedLetter}'");
                }
                if (!knownLetters.Contains("_")) { break; }
            }
            Console.WriteLine($"Word: {knownLetters}");
            Console.WriteLine("Congrats!");
        }
    }
}