namespace SalesLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dear person,");
            DisplayContactInfo();
            Console.WriteLine("This is a letter.");
            DisplayContactInfo();
            Console.WriteLine("And this is spam.");
            DisplayContactInfo();
        }

        private static void DisplayContactInfo()
        {
            Console.WriteLine("Phone Number:   999-999-9999");
            Console.WriteLine("Email Address:  nowhere@gmail.com");
            Console.WriteLine("Street Address: N/A");
        }
    }
}