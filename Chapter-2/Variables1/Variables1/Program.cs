using System;

namespace Variables1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Levi";
            int someMoney = 10;
            Console.WriteLine($"{myName,10}");
            Console.WriteLine($"{myName,4}");
            Console.WriteLine($"{myName}");
            Console.WriteLine("I have ${0}. ${0} is a lot.", someMoney);
            Console.WriteLine("This is my string, it is getting quite long now.");

            if (x) Console.WriteLine("OK");
        }
    }
}
