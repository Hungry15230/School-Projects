namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int userInput = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{userInput} x {i} = {userInput * i}");
            }
        }
    }
}
