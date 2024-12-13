using static System.Console;

namespace DemoEscapeSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("This line\tcontains two\ttabs.");
            WriteLine("This statement\ncontains a new line.");
            WriteLine("This statement sounds an alert. \a");
        }
    }
}
