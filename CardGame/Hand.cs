namespace CardGame
{
    class Hand
    {
        private Card[] cards;
        public Hand()
        {
            cards = new Card[0];
        }

        public void AddCard(Card card)
        {
            if (cards == null)
                throw new ArgumentNullException("Card cannot be null.");
            Array.Resize(ref cards, cards.Length + 1);
            cards[cards.Length - 1] = card;
        }

        public Card TakeCard()
        {
            if (cards.Length == 0)
                throw new InvalidOperationException("No cards in hand.");
            Card card = cards[cards.Length - 1];
            Array.Resize(ref cards, cards.Length - 1);
            return card;
        }

        public override string ToString()
        {
            return $"[{string.Join(',', (object[])cards)}]";
        }
    }
}