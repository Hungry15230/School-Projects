namespace MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1D Array
            int[] num = { 4, 5, 5 };

            // 2D Array
            double[,] sales = {{14.00, 15.00, 16.00, 17.00 },
                               {21.99, 34.55, 67.88, 31.99 },
                               {12.03, 55.55, 32.89, 1.17 }};

            // 3D Array
            int[,,] rents = { {{400, 500}, {450, 550},   {500, 550}},
                              {{510, 610}, {710, 810},   {910, 1010}},
                              {{525, 625}, {725, 825},   {925, 1025}},
                              {{850, 950}, {1050, 1150}, {1250, 1350}} };

            int building = 1, floor = 2, bedrooms = 1;

            Console.WriteLine(rents[building, floor, bedrooms]);

            // Jagged Array
            double[][] tickets = {
                new double[] {5.50, 6.75, 7.95, 9.00, 12.00, 13.00, 14.50, 17.00, 19.00, 20.25},
                new double[] {5.00, 6.00},
                new double[] {7.50, 9.00, 9.95, 12.00, 13.00, 14.00},
                new double[] {3.50, 6.45, 9.95, 10.00, 12.75},
                new double[] {15.00, 16.00}};
            int route = 2, stop = 3;

            Console.WriteLine(tickets[route][stop]);
        }
    }
}
