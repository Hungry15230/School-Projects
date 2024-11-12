namespace HurricaneModularized
{
    internal class Program
    {
        static string GetCategory(int windSpeed)
        {
            string category;
            // Cat 5 >= 157
            // Cat 4 >= 130
            // Cat 3 >= 111
            // Cat 2 >= 96
            // Cat 1 >= 74
            if (windSpeed >= 157) { category = "Category 5"; }
            else if (windSpeed < 157 && windSpeed >= 130) { category = "Category 4"; }
            else if (windSpeed < 130 && windSpeed >= 111) { category = "Category 3"; }
            else if (windSpeed < 111 && windSpeed >= 96) { category = "Category 2"; }
            else if (windSpeed < 96 && windSpeed >= 74) { category = "Category 1"; }
            else { category = "Not A Hurricane"; }
            return category;
        }
        static void Main(string[] args)
        {
            Console.Write("Wind Speed (mph): ");
            int windSpeed = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(GetCategory(windSpeed));
        }
    }
}