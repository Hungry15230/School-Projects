namespace TipCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateTip(10, 0.1);
            Console.WriteLine("-------------------");
            CalculateTip(10, 10);
        }
        static void CalculateTip(double mealPrice, double tip)
        {
            Console.WriteLine($"Meal Price:  {mealPrice.ToString("C")}");
            Console.WriteLine($"Tip Percent: {tip * 100}%");
            Console.WriteLine($"Tip Amount:  {(mealPrice * (1 + tip)).ToString("C")}");
        }
        static void CalculateTip(double mealPrice, int tip)
        {
            Console.WriteLine($"Meal Price:  {mealPrice.ToString("C")}");
            Console.WriteLine($"Tip Percent: {tip}%");
            Console.WriteLine($"Tip Amount:  {(mealPrice * (1 + (Convert.ToDouble(tip) / 100))).ToString("C")}");
        }
    }
}
