namespace AdmissionModularized
{
    internal class Program
    {
        static string TestAcceptance(double gpa, int admissionTestScore)
        {
            if ((admissionTestScore >= 60 && gpa >= 3.0) || (admissionTestScore >= 80 && gpa < 3.0))
            {
                return "Accept";
            }
            else
            {
                return "Reject";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("High School GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Admission Test Score: ");
            int admissionTestScore = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(TestAcceptance(gpa, admissionTestScore));
        }
    }
}