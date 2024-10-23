namespace EnterUppercaseLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = 'A';
            while (true)
            {
                Console.Write("Enter a character: ");
                letter = Convert.ToChar(Console.ReadLine());
                if (letter == '!') { break; }
                bool letterIsUpper = char.IsUpper(letter);
                if (letterIsUpper)
                {
                    Console.WriteLine("Uppercase.");
                } else
                {
                    Console.WriteLine("Not uppercase.");
                }
            }
        }
    }
}
