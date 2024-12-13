namespace Flights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flightNumbers = { 201, 321, 510, 633 };
            string[] airportCodes = { "AUS", "CRP", "DFW", "HOU" };
            string[] airportNames = { "Austin", "Corpus Christi", "Dallas Fort Worth", "Houston" };
            int[] flightTimes = { 0710, 0830, 0915, 1140 };
            string input = Console.ReadLine() ?? "";
            string output;
            int flightNumber;
            // I'm tired, but proud.
            // This kind of works: int.TryParse(input, out flightNumber) ? flightNumber : input;
            if (int.TryParse(input, out flightNumber))
                output = GetFlightInfo(flightNumber, flightNumbers, airportCodes, airportNames, flightTimes);
            else
                output = GetFlightInfo(input.ToUpper(), flightNumbers, airportCodes, airportNames, flightTimes);
            Console.WriteLine(output);
        }
        static string GetFlightInfo(int flightNumber, int[] flightNumbers, string[] airportCodes, string[] airportNames, int[] flightTimes)
        {
            int index = Array.BinarySearch(flightNumbers, flightNumber);
            if (index < 0) { return "Error: Flight not found."; }
            string airportCode = airportCodes[index];
            string airportName = airportNames[index];
            int flightTime = flightTimes[index];
            return $"Flight Number: {flightNumber}\n" +
                   $"Airport Code:  {airportCode}\n" +
                   $"Airport Name:  {airportName}\n" +
                   $"Flight Time:   {flightTime:0000}";
        }
        static string GetFlightInfo(string airportCode, int[] flightNumbers, string[] airportCodes, string[] airportNames, int[] flightTimes)
        {
            int index = Array.BinarySearch(airportCodes, airportCode);
            if (index < 0) { return "Error: Flight not found."; }
            int flightNumber = flightNumbers[index];
            string airportName = airportNames[index];
            int flightTime = flightTimes[index];
            return $"Flight Number: {flightNumber}\n" +
                   $"Airport Code:  {airportCode}\n" +
                   $"Airport Name:  {airportName}\n" +
                   $"Flight Time:   {flightTime:0000}";
        }
    }
}
