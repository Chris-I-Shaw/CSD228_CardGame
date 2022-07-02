namespace CardGame
{
    class Player
    {
        private string name;
        private Hand hand;
        private int score;

        public Player(string name)
        {
            if(name == null || name == "")
                throw new ArgumentException("Name cannot be null or empty");
            this.name = name;
            this.hand = new Hand();
            this.score = 0;
        }

        public string GetName()
        {
            return name;
        }

        public Hand GetHand()
        {
            return hand;
        }

        public int GetScore()
        {
            return score;
        }

        public void SetScore(int score)
        {
            if(score >= this.score)
                this.score = score;
        }

        public void AddCard(Card card)
        {
            if(card == null)
                throw new ArgumentNullException("Card cannot be null");
            hand.AddCard(card);
        }

        public Card TakeCard()
        {
            return hand.TakeCard();
        }

        public override string ToString()
        {
            return $"Name:\t{name}\nPoints:\t{score}\nHand:\t{hand}";

        }

    }
}
