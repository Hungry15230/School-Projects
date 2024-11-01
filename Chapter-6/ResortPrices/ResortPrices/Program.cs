namespace ResortPrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many days will you be staying with Carefree Resorts? ");
            int daysStaying = Convert.ToInt32(Console.ReadLine());
            int[] dayLowRanges = { 1, 3, 5, 8 };
            int[] nightlyRates = { 200, 180, 160, 145};
            int sub = dayLowRanges.Length - 1;
            while (sub >= 0 && daysStaying < dayLowRanges[sub]) --sub;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Days staying: {daysStaying}");
            Console.WriteLine($"Price/Night:  {nightlyRates[sub]}$");
            Console.WriteLine($"Total cost:   {daysStaying * nightlyRates[sub]}$");
        }
    }
}