namespace DeliveryCharges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zipCodes = { 40365, 84590, 34729, 45863, 62157, 91376, 15793, 59874, 28749, 85487 };
            int[] deliveryCharges = { 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 };
            Console.Write("Enter a zip code: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int zipIndex = Array.BinarySearch(zipCodes, userInput);
            if (zipIndex < 0)
            {
                Console.WriteLine("Not in delivery area.");
                return;
            }
            else
            {
                Console.WriteLine("In delivery area.");
            }
            Console.WriteLine($"Delivery fee for zip code {userInput}: {deliveryCharges[zipIndex]}$");
        }
    }
}
