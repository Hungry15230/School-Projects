namespace ConvertMilesToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometers = Conversion(miles);
            Console.WriteLine($"Kilometers: {kilometers}");

        }
        static double Conversion(double miles)
        {
            return miles * 1.60934;
        }
    }
}