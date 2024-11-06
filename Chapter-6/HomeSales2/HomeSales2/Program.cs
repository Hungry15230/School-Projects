namespace HomeSales2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentSale;
            int allSales = 0;
            int prevSalesTotal = 0;
            int[] salesPerPerson = { 0, 0, 0 };

            char salespersonInitial;
            char[] salesInitials = { 'D', 'E', 'F' };

            string winner = "None";
            string[] salesPeople = { "Danielle", "Edward", "Francis" };
            while (true)
            {
                Console.Write("Enter a salesperson initial (D, E, F, and Z to exit): ");
                salespersonInitial = Char.ToUpper(Convert.ToChar(Console.ReadLine() ?? "Error"));

                if (salespersonInitial == 'Z') { break; }
                if (salesInitials.Contains(salespersonInitial))
                {
                    Console.Write("Enter the sale amount: ");
                    currentSale = Convert.ToInt32(Console.ReadLine());
                    salesPerPerson[Array.BinarySearch(salesInitials, salespersonInitial)] += currentSale;
                    allSales += currentSale;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            Console.WriteLine($"Total Sales:      {allSales}");
            Console.WriteLine($"Danielle's Sales: {salesPerPerson[0]}");
            Console.WriteLine($"Edward's Sales:   {salesPerPerson[1]}");
            Console.WriteLine($"Francis' Sales:   {salesPerPerson[2]}");
            foreach (int salesTotal in salesPerPerson)
            {
                if (salesTotal > prevSalesTotal)
                {
                    winner = salesPeople[Array.BinarySearch(salesPerPerson, salesTotal)];
                }
                prevSalesTotal = salesTotal;
            }
            Console.WriteLine($"Winner: {winner}");
        }
    }
}