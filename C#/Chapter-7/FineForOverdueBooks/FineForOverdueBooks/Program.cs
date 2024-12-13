namespace FineForOverdueBooks
{
    internal class Program
    {
        static void CalcBooksFees(int booksOverdue, int daysOverdue)
        {
            double fees;
            if (daysOverdue <= 7)
            {
                fees = daysOverdue * 0.10 * booksOverdue;
            } else
            {
                fees = (0.70 * booksOverdue) + ((daysOverdue - 7) * 0.20 * booksOverdue);
            }
            Console.WriteLine($"Fees for overdur books: {fees.ToString("C")}");
        }
        static void Main(string[] args)
        {
            Console.Write("How many books overdue: ");
            int booksOverdue = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many days overdue: ");
            int daysOverdue = Convert.ToInt32(Console.ReadLine());
            CalcBooksFees(booksOverdue, daysOverdue);
        }
    }
}