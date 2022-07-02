namespace CardGame
{
    class Card
    {
        private Rank rank;
        private Suit suit;
        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"[{rank} of {suit}]";
        }
        
    }
    
    
}