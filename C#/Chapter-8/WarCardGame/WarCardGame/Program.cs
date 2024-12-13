namespace WarCardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vars
            string[] suites = { "Spades", "Hearts", "Clubs", "Diamonds" };
            FillDeck(suites, out string[] cards);
            string[] cardCache = new string[52];
            string computerCard = SelectCard(cards);
            // Each deal
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($"Iteration: {i}");

                while (SelectCard(cards, ref cardCache, ref string playerCard)) { }


                Console.WriteLine(playerCard);
                Console.WriteLine(computerCard);
            }
            Console.WriteLine("Finished");
            foreach (string card in cardCache)
            {
                Console.WriteLine(card);
            }
        }
        static string[] FillDeck(string[] suites, out string[] cards)
        {
            cards = new string[52];
            int _j = 1;
            int _k = 0;
            for (int i = 0; i < 52; i++)
            {
                cards[i] = $"{(_j==11?"Jack":_j==12?"Queen":_j==13?"King":_j)} of {suites[_k]}";
                if (_j < 13) { _j++; }
                else { _j = 1; _k++; }
            }
            return cards;
        }
        static bool SelectCard(string[] cards, ref string[] cardCache, ref string playerCard)
        {
            Random random = new Random();
            playerCard = cards[random.Next(0, 51)];
            if (cardCache.Contains(playerCard))
            {
                cardCache[Array.IndexOf(cards, playerCard)] = playerCard;
                return false;
            }
            else { return true; }
        }
    }
}
