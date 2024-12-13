namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMovie("Return of the King", 180);
            DisplayMovie("The Two Towers");
        }

        static void DisplayMovie(string name, int minutes = 90)
        {
            Console.WriteLine($"Movie name: {name}.");
            Console.WriteLine($"Movie time: {minutes} minutes.");
        }
    }
}
