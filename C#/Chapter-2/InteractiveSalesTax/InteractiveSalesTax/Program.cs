using System;

namespace InteractiveSalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TAX_RATE = 0.06;
            double itemPrice;
            double total;
            Console.Write("Enter the price of an item: ");
            itemPrice = Convert.ToDouble(Console.ReadLine());
            total = itemPrice * TAX_RATE;
            Console.WriteLine("With a tax rate of {0}, a {1} item costs {2} more.", TAX_RATE, itemPrice.ToString("C"), total.ToString("C"));
        }
    }
}
