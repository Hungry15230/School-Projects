using System.Collections.Immutable;

namespace SortWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sort("Apple");
            Console.WriteLine("----------");
            Sort("Apple", "Zebra");
            Console.WriteLine("----------");
            Sort("Apple", "Zebra", "Coconut", "Bannana", "Dog");
            Console.WriteLine("----------");
            Sort("Apple", "Zebra", "Coconut", "Bannana", "Dog",
                 "Cracker", "Lake", "Mountain", "Sea", "Ocean");
        }

        static void Sort(params string[] args)
        {
            Array.Sort(args);
            foreach (string word in args)
                Console.WriteLine(word);
        }
    }
}