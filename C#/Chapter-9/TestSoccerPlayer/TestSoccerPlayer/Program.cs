namespace TestSoccerPlayer
{
    class SoccerPlayer
    {
        public string Name {  get; set; }
        public int Goals {get; set;}
        public int Assists {get; set;}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SoccerPlayer player = new SoccerPlayer();
            player.Name = "Bob";
            player.Goals = 1;
            player.Assists = 0;
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Goals: {player.Goals}");
            Console.WriteLine($"Assists: {player.Assists}");
        }
    }
}
