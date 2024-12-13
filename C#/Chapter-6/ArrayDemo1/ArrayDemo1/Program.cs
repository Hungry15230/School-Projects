namespace ArrayDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] payRate = { 13.00, 17.35, 19.12, 22.45 };
            for(int x = 0; x < payRate.Length; ++x)
            {
                Console.WriteLine($"Pay rate {x} is {payRate[x].ToString("C")}");
            }
        }
    }
}