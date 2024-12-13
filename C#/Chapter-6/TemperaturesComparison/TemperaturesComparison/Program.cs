namespace TemperaturesComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temperatures = new int[5];
            int totalTemperatures = 0;
            int prevTemp;
            bool gettingWarmer = false;
            bool gettingColder = false;
            for (int i = 0; i < temperatures.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter temperature {i+1}, -30F to 130F: ");
                    int enteredTemperature = Convert.ToInt16(Console.ReadLine());
                    if (enteredTemperature >= -30 && enteredTemperature <= 130)
                    {
                        temperatures[i] = enteredTemperature;
                        totalTemperatures += enteredTemperature;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again.");
                    }
                }
            }
            // Check for 'Getting Warmer'
            prevTemp = -31;
            foreach (int temp in temperatures)
            {
                if (temp > prevTemp) { gettingWarmer = true; prevTemp = temp; }
                else { gettingWarmer = false; break; }
            }
            // Create a reversed list
            int[] reversedTemperatures = temperatures;
            reversedTemperatures.Reverse();
            // Check for 'Getting Colder'
            prevTemp = 131;
            foreach (int temp in reversedTemperatures)
            {
                if (temp < prevTemp) { gettingColder = true; prevTemp = temp; }
                else { gettingColder = false; break; }
            }
            if (gettingWarmer) Console.WriteLine("Getting Warmer");
            else if (gettingColder) Console.WriteLine("Getting Colder");
            else Console.WriteLine("It's a mixed bag.");
            Console.WriteLine("-------------------------");
            foreach (int temp in temperatures) { Console.WriteLine($"{temp}"); }
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Average: {Convert.ToDouble(totalTemperatures/temperatures.Length)}");
        }
    }
}
