namespace CheckZips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zipCodes = { 40365, 84590, 34729, 45863, 62157, 91376, 15793, 59874, 28749, 85487 };
            Console.Write("Enter a zip code: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (Array.BinarySearch(zipCodes, userInput) < 0)
            {
                Console.WriteLine("Not in delivery area.");
            } else
            {
                Console.WriteLine("In delivery area.");
            }
        }
    }
}
