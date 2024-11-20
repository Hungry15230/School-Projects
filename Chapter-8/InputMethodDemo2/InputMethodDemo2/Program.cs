namespace InputMethodDemo2
{
    internal class Program
    {
        static void Main()
        {
            int first, second;
            InputMethod(out first, out second);
            Console.WriteLine($"After InputMethod first is {first} and second is {second}");
        }
        private static void InputMethod(out int one, out int two)
        {
            one = DataEntry("first");
            two = DataEntry("second");
        }
        static int DataEntry(string myString)
        {
            Console.Write($"Enter {myString} integer: ");
            return Convert.ToInt16(Console.ReadLine() ?? "");
        }
    }
}