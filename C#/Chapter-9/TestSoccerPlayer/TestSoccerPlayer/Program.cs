/*
    Create an application named TestSoccerPlayer that instantiates and displays a
    SoccerPlayer object. The SoccerPlayer class contains properties that hold a
    player’s name (a string), jersey number (an integer), goals scored (an integer), and
    assists (an integer).
*/

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
