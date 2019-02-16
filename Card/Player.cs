using System.Collections.Generic;
using System;

namespace Card
{
    public class Player
    {
        public string Name { get; set;}
        public List<Card> hands = new List<Card> ();
        public Player(string name)
        {
            Name = name;
        }

        public void Draw(Deck deck)
        {
            // Deck deck = new Deck ();
            Random rand = new Random();
            int randomnum = rand.Next(deck.cards.Count);            
            Card drawedCard = deck.cards[randomnum];
            hands.Add(drawedCard);
            deck.cards.Remove(drawedCard);
        }

        public object Discard(int x)
        {
            if( x > hands.Count){
                return null;
            }
            Card indx = hands[x];
            hands.Remove(indx);
            return indx;
        }
    }
}