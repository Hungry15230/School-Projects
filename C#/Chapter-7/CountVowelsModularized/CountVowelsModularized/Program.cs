namespace CountVowelsModularized
{
    internal class Program
    {
        static int CountVowels(string userInput)
        {
            int vowels = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                char charToEval = Char.ToLower(userInput[i]);
                if (charToEval == 'a' || charToEval == 'e' || charToEval == 'i' || charToEval == 'o' || charToEval == 'u') { vowels++; }
            }
            return vowels;

        }
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine() ?? "";
            Console.WriteLine(CountVowels(userInput) + " vowels.");
        }
    }
}