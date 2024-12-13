using System;
using static System.Console;


namespace InteractiveAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int first, second;
            Write("Your name: ");
            name = ReadLine();
            Write("Hello {0}. Enter number 1: ",name);
            first = Convert.ToInt32(ReadLine());
            Write("Enter number 2: ");
            second = Convert.ToInt32(ReadLine());
            WriteLine("Sum of number 1 and 2 is {0}.", first + second);
        }
    }
}
