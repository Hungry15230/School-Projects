namespace HomeSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char salespersonInitial;
            int currentSale;
            int dSales = 0;
            int eSales = 0;
            int fSales = 0;
            int allSales = 0;
            while (true)
            {
                Console.Write("Enter a salesperson initial (D, E, F, and Z to exit): ");
                salespersonInitial = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

                if (salespersonInitial == 'Z') { break; }
                if (salespersonInitial == 'D' || salespersonInitial == 'E' || salespersonInitial == 'F')
                {
                    Console.Write("Enter the sale amount: ");
                    currentSale = Convert.ToInt32(Console.ReadLine());
                    if (salespersonInitial == 'D') { dSales += currentSale; allSales += currentSale; }
                    else if (salespersonInitial == 'E') { eSales += currentSale; allSales += currentSale; }
                    else if (salespersonInitial == 'F') { fSales += currentSale; allSales += currentSale; }
                } else
                {
                    Console.WriteLine("Invalid");
                }
            }
            Console.WriteLine($"Total Sales:      {allSales}");
            Console.WriteLine($"Danielle's Sales: {dSales}");
            Console.WriteLine($"Edward's Sales:   {eSales}");
            Console.WriteLine($"Francis' Sales:   {fSales}");
            if (dSales > eSales && dSales > fSales) { Console.WriteLine("Sales Winner: Danielle"); }
            if (eSales > dSales && eSales > fSales) { Console.WriteLine("Sales Winner: Edward"); }
            if (fSales > eSales && fSales > dSales) { Console.WriteLine("Sales Winner: Francis"); }
        }
    }
}
