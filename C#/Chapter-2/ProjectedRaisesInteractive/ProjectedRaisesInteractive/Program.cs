using System;

namespace ProjectedRaisesInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            double NEXT_YEARS_RAISE = 1.04; // 4%
            /*
            double employee1Salary = 12.08; // Per hour
            double employee2Salary = 13.56; // Per hour
            double employee3Salary = 15.32; // Per hour
            */
            Console.Write("Employee 1 Salary: ");
            double employee1Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Employee 2 Salary: ");
            double employee2Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Employee 3 Salary: ");
            double employee3Salary = Convert.ToDouble(Console.ReadLine());
            string employee1Desc = $"Employee 1 just joined this year, he currently has a salary per hour of {employee1Salary:C}." +
                $"\nHis good work ethic warrants him to recieve the company-wide raise of 4% for a {employee1Salary * NEXT_YEARS_RAISE:C} salary";
            string employee2Desc = $"Employee 2 has been at the company for 5 years now and has a salary of {employee2Salary:C}." +
                $"\nThis employee might be promoted to manager soon but is eligible for the 4% raise and his new salary will be {employee2Salary * NEXT_YEARS_RAISE:C}.";
            string employee3Desc = $"Employee 3 has been here for many years and is an invaluable asset as well as a manager for the company, current salary is {employee3Salary:C}." +
                $"\nOf course, Employee 3 is eligible for the same 4% raise and his new salary will be {employee3Salary * NEXT_YEARS_RAISE:C}.";

            Console.WriteLine(employee1Desc);
            Console.WriteLine(employee2Desc);
            Console.WriteLine(employee3Desc);
        }
    }
}
