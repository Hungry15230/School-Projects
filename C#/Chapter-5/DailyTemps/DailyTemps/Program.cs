namespace DailyTemps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List experiments
            List<int> myList = [1, 2, 3];
            Console.WriteLine(myList.Contains(1));
            */
            int response = 5;
            int totalTemp = 0;
            int totalResponses = 0;
            while (response != 0)
            {
                Console.Write("Enter a daily high temperature between -20F and 130F, 0 to quit: ");
                response = Convert.ToInt32(Console.ReadLine());
                if (response == 0) { break; }
                if (response <= 130 && response >= -20)
                {
                    totalResponses++;
                    totalTemp += response;
                    Console.WriteLine("Temp added");
                } else
                {
                    Console.WriteLine("Error");
                }
            }
            Console.WriteLine("Total temperatures: " + totalResponses);
            Console.WriteLine("Average temperature: " + totalTemp/totalResponses);
        }
    }
}
