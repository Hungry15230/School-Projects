namespace CountVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vowels = 0;
            string userInput = Console.ReadLine();
            for (int i = 0; i < userInput.Length; i++) 
            {
                char charToEval = Char.ToLower(userInput[i]);
                if (charToEval == 'a' || charToEval == 'e' || charToEval == 'i' || charToEval == 'o' || charToEval == 'u') { vowels++; }
            }
            Console.WriteLine(vowels + " vowels.");
        }
    }
}