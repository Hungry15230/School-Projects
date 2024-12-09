using System.Globalization;

namespace RateLawCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int orderX = GetOrder(1.50, 0.50, 0.0059, 0.0020);
            // int orderY = GetOrder(0.25, 0.50, 0.0059, 0.0230);
            // int orderZ = GetOrder(0.50, 0.25, 0.0470, 0.0230);
            double molarity1;
            double molarity2;
            double rate1;
            double rate2;
            double rate;
            double k;
            List<int> orders = new List<int>();
            List<double> molarities = new List<double>();
            Console.Write("Number of species in reaction: ");
            int species = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("----------");
            Console.WriteLine("All measurements must be in decimal notation, not scientific.");
            Console.WriteLine("----------");
            Console.WriteLine("Finding orders...");
            for (int i = 0; i < species; i++)
            {
                Console.Write($"1st Molarity of species {i + 1}: ");
                molarity1 = double.Parse(Console.ReadLine() ?? "");
                Console.Write($"2nd Molarity of species {i + 1}: ");
                molarity2 = double.Parse(Console.ReadLine() ?? "");
                Console.Write($"1st Rate of species {i + 1}: ");
                rate1 = double.Parse(Console.ReadLine() ?? "");
                Console.Write($"2nd Rate of species {i + 1}: ");
                rate2 = double.Parse(Console.ReadLine() ?? "");
                int order = GetOrder(molarity1, molarity2, rate1, rate2);
                orders.Add(order);
                if (i < species - 1) { Console.WriteLine(); }
            }
            Console.WriteLine("----------");
            Console.WriteLine("Finding k...");
            for (int i = 0; i < species; i++)
            {
                Console.Write($"Molarity of species {i + 1}: ");
                molarities.Add(double.Parse(Console.ReadLine() ?? ""));
            }
            Console.Write("Rate to find k with: ");
            rate = double.Parse(Console.ReadLine() ?? "");
            k = GetKValue(orders, molarities, rate);
            Console.WriteLine("----------");
            Console.WriteLine("Results: ");
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"Species {i+1}'s order: {orders[i]}");
            }
            Console.WriteLine($"Value of k: {k}");
            Console.WriteLine("----------");
        }
        static int GetOrder(double molarity1, double molarity2, double rate1, double rate2)
        {
            double molarityAverage = molarity1 / molarity2;
            double rateAverage = rate1 / rate2;
            double rawOrder = molarityAverage / rateAverage;
            int order = rawOrder > 1.4 ? 2 : 1;
            return order;
        }
        static double GetKValue(List<int> orders, List<double> molarities, double rate)
        {
            int i = 0;
            double num = 1;
            double k;
            do
            {
                num *= Math.Pow(molarities[i], orders[i]);
                i++;

            } while (i < orders.Count);
            k = rate / num;
            return k;
        }
    }
}
