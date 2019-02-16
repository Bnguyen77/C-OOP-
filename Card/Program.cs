using System;

namespace Card
{

    // public Card Deal () {
    //         Card dealtCard = cards[0];
    //         cards.Remove (dealtCard);
    //         return dealtCard;
    //     }
    class Program {
        static void Main (string[] args) {
            Deck deck = new Deck ();
            Player player1 = new Player ("player1");
            // deck.ReadDeck();
            deck.Shuffle();
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Draw(deck);
            // deck.ReadDeck();
        }
    }
}