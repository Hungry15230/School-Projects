using System;
using static System.Console;
namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Normal word: ");
            string normalStr = ReadLine();
            string newStr = normalStr.Substring(1,(normalStr.Length-1))+normalStr.Substring(0,1)+"ay";
            WriteLine(newStr);
            WriteLine(normalStr.Length);
        }
    }
}
