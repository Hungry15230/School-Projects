namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] myArray = new double[10];
            for (int i = 0; i < myArray.Length; i++) myArray[i] += i+1;
            while (true)
            {
                Console.WriteLine("Pick an option:");
                Console.WriteLine("  1. View list from first to last position.");
                Console.WriteLine("  2. View list from last to first position.");
                Console.WriteLine("  3. Choose a specific position to view.");
                Console.WriteLine("  4. Quit.");
                Console.Write("> ");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1: foreach(int i in myArray) Console.WriteLine(i); break;
                    case 2: foreach (int i in myArray.Reverse()) Console.WriteLine(i); break;
                    case 3:
                        Console.Write("Desired position in the list (1-10): ");
                        int desiredPosition = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(myArray[desiredPosition-1]);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Error, try again.");
                        break;
                }
            }
        }
    }
}
