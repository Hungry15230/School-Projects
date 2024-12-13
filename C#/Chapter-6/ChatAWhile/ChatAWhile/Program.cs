namespace ChatAWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] areaCodes = { 262, 414, 608, 715, 815, 920 };
            double[] payRates = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            Console.Write("Area code: ");
            int areaCode = Convert.ToInt16(Console.ReadLine());
            Console.Write("Call time, in minutes: ");
            int callTime = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Total call cost: {payRates[Array.BinarySearch(areaCodes,areaCode)]*callTime}$");
        }
    }
}
