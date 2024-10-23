Console.Write("High School GPA: ");
double gpa = Convert.ToDouble(Console.ReadLine());
Console.Write("Admission Test Score: ");
int admissionTestScore = Convert.ToInt16(Console.ReadLine());
if ((admissionTestScore >= 60 && gpa >= 3.0) || (admissionTestScore >= 80 && gpa < 3.0))
{
    Console.WriteLine("Accept");
} else 
{
    Console.WriteLine("Reject");
}