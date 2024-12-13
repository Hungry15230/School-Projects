namespace Auction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MIN_BID = 10;
            string input;
            Console.Write("Enter your bid: ");
            input = Console.ReadLine() ?? "";
            if (int.TryParse(input, out int bidAsInt))
                IsBidValid(bidAsInt, MIN_BID);
            else if (double.TryParse(input, out double bidAsDouble))
                IsBidValid(bidAsDouble, MIN_BID);
            else IsBidValid(input, MIN_BID);
        }
        static void IsBidValid(int bid, int min)
        {
            if (bid >= min) { Console.WriteLine("Your bid is above the minimum."); }
            else Console.WriteLine("Your bid is below the minimum: $10.");
        }
        static void IsBidValid(double bid, int min)
        {
            if (bid >= min) { Console.WriteLine("Your bid is above the minimum."); }
            else Console.WriteLine("Your bid is below the minimum: $10.");
        }
        static void IsBidValid(string bid, int min)
        {
            if (bid.First() == '$')
            {
                if (bid.Length > 1)
                {
                    bid = bid.Substring(1, bid.Length - 1);
                    double.TryParse(bid, out double bidAsDouble);
                    IsBidValid(bidAsDouble, min);
                }
                else
                    Console.WriteLine("Invalid formatting");
            }
            else
            {
                if (bid.Contains("dollars"))
                {
                    bid = "$" + bid.Substring(0, bid.IndexOf("dollars")).Trim();
                    IsBidValid(bid, min);
                }
            }
        }
    }
}
