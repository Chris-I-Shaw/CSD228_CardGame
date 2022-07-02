namespace CardGame
{
    class Deck
    {
        private Card[] cards;
        public Deck()
        {
            Rank[] ranks = Enum.GetValues<Rank>();
            Suit[] suits = Enum.GetValues<Suit>();
            cards = new Card[ranks.Length * suits.Length];

            int i = 0;
            foreach(Suit suit in suits)
            {
                foreach(Rank rank in ranks)
                {
                    cards[i++] = new Card(rank, suit);
                    
                }
            }
        }

        public bool HasCards()
        {
            return cards.Length > 0;
        }

        public Card DrawCard()
        {
            if(cards.Length == 0) 
                throw new InvalidOperationException("There are no cards left in the deck.");
            Card card = cards[cards.Length - 1];
            Array.Resize<Card>(ref cards, cards.Length - 1);
            return card;
        }

        public void Shuffle()
        {
            int numCards = cards.Length;
            for(int i = 0; i < (numCards - 1); i++)
            {
                int random = i + Program.rng.Next(numCards - i);
                Card randomCard = cards[random];
                cards[i] = cards[i];
                cards[i] = randomCard;
            }
        }

        public override string ToString()
        {
            return $"[{string.Join(',', (object[])cards)}]";
        }
    }
}