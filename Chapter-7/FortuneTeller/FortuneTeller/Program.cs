namespace FortuneTeller
{
    internal class Program
    {
        static void DisplayFortunes(string fortune1, string fortune2)
        {
            Console.WriteLine(fortune1);
            Console.WriteLine(fortune2);
        }
        static void Main(string[] args)
        {
            string[] fortunes = {"I see misfortune in your future.", "I see dissapointment in your future.", "I see despair in your future.",
                                 "I see people in your future.", "I see buildings in your future.", "I see mercantalism in your future."};
            Random random = new Random();
            DisplayFortunes(fortunes[random.Next(0, 6)], fortunes[random.Next(0, 6)]);
        }
    }
}