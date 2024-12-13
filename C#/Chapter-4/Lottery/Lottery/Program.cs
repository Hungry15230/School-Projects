using static System.Console;

namespace Lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randNumberGen = new Random();
            int min = 1, max = 4;
            int randNum1 = randNumberGen.Next(min, max);
            int randNum2 = randNumberGen.Next(min, max);
            int randNum3 = randNumberGen.Next(min, max);
            int numsCorrect = 0;
            int numsInOrder = 0;
            Write("Enter number 1: ");
            int num1 = Convert.ToInt16(ReadLine());
            Write("Enter number 2: ");
            int num2 = Convert.ToInt16(ReadLine());
            Write("Enter number 3: ");
            int num3 = Convert.ToInt16(ReadLine());
            if (num1 == randNum1 || num1 == randNum2 || num1 == randNum3) {
                if (num1 == randNum1) { numsInOrder++; }
                numsCorrect++;
            }
            if (num2 == randNum1 || num2 == randNum2 || num2 == randNum3) {
                if (num2 == randNum2) { numsInOrder++; }
                numsCorrect++;
            }
            if (num3 == randNum1 || num3 == randNum2 || num3 == randNum3) {
                if (num3 == randNum3) { numsInOrder++; }
                numsCorrect++;
            }
            if (numsInOrder == 3) { WriteLine("Award: 10,000$"); }
            else if (numsCorrect == 3) { WriteLine("Award: 1,000$"); }
            else if (numsCorrect == 2) { WriteLine("Award: 100$"); }
            else if (numsCorrect == 1) { WriteLine("Award: 10$"); }
            else { WriteLine("Award: 0$"); }
            WriteLine("Numbers: "+randNum1+randNum2+randNum3);
        }
    }
}
