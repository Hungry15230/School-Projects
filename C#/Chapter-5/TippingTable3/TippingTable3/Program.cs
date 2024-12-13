namespace TippingTable3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tipRate;
            double tip;
            Console.Write("Lowest tipping percentage: ");
            double LOWRATE = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Highest tipping percentage: ");
            double MAXRATE = Convert.ToDouble(Console.ReadLine()) / 100;
            const double TIPSTEP = 0.05;
            Console.Write("Lowest dinner price: ");
            double dinnerPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Highest dinner price: ");
            double MAXDINNER = Convert.ToDouble(Console.ReadLine());
            const double DINNERSTEP = 10.00;

            Console.Write("   Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
            {
                Console.Write("{0, 8}", tipRate.ToString("F"));
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            tipRate = LOWRATE;
            do
            {
                Console.Write("{0, 8}", dinnerPrice.ToString("C"));
                while (tipRate <= MAXRATE)
                {
                    tip = dinnerPrice * tipRate;
                    Console.Write("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                Console.WriteLine();
            } while (dinnerPrice <= MAXDINNER);

        }
    }
}