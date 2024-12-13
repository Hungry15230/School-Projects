namespace PaintingEstimate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int costPerSqFt = 6;
            int roomHeight = 9;
            Console.Write("Length of room: ");
            int roomLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width of room: ");
            int roomWidth = Convert.ToInt32(Console.ReadLine());
            int totalCost = CalcPaintCost(costPerSqFt, roomHeight, roomLength, roomWidth);
            Console.WriteLine($"Total Cost: {totalCost.ToString("C")}$");
        }
        static int CalcPaintCost(int costPerSqFt, int roomHeight, int roomLength, int roomWidth)
        {
            return ((roomHeight*roomLength*2)+(roomHeight*roomWidth*2))*costPerSqFt;
        }
    }
}