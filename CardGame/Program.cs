namespace CardGame
{
    class Program
    {
        static public Random rng = new Random();
        static void Main(string[] args)
        {
            rng = (args.Length > 0) ? new Random(int.Parse(args[0])) : rng;

            const int NumCardsToDeal = 5;

            Deck deck = new Deck();
            Console.WriteLine(deck);
            Console.WriteLine("New Deck");
            Console.WriteLine("----------------------------------------------");

            deck.Shuffle();

            Console.WriteLine(deck);

            Console.WriteLine("----------------------------------------------");

            Player[] players = new Player[4];
            players[0] = new Player("Tom");
            players[1] = new Player("Pat");
            players[2] = new Player("Wendell");
            players[3] = new Player("Siri");
            for(int i = 0; i < NumCardsToDeal; i++)
                {
                    foreach(Player player in players)
                        player.AddCard(deck.DrawCard());

                }
            
            Console.WriteLine("-----------------------------------------------");


            foreach(Player player in players)
                Console.WriteLine($"{player.GetName()+":",-14} {player.GetHand()}");

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("The remaining cards in the deck.");
            Console.WriteLine(deck);
        }
    }
}