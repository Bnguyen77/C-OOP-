using System;
using System.Collections.Generic;

namespace Card {
    // Deck Class
    public class Deck {
        string[] stringVals = new string[] {
            "Ace",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
        };
        string[] suits = new string[] {
            "Clubs",
            "Spades",
            "Diamonds",
            "Heart",
        };
        public List<Card> cards = new List<Card> ();
        public Deck () {
            foreach (string suit in suits) {
                int value = 1;
                foreach (var stringVal in stringVals) {
                    Card newCard = new Card (stringVal, suit, value);
                    cards.Add (newCard);
                    value++;
                }
            }
        }

        public void ReadDeck () {
            foreach (Card card in cards) {
                System.Console.WriteLine ($"{card.StringVal} of {card.Suit}");
            }
        }

        public void Shuffle () {
            Random rand = new Random ();
            for (int i = 0; i < cards.Count; i++) {
                int newIndx = rand.Next (cards.Count);
                Card temp = cards[i];
                cards[i] = cards[newIndx];
                cards[newIndx] = temp;
            }
        }
        public Card Deal () {
            Card dealtCard = cards[0];
            cards.Remove (dealtCard);
            return dealtCard;
        }

        public void Reset (){
            cards = new List<Card>();
            foreach (string suit in suits) {
                int value = 1;
                foreach (var stringVal in stringVals) {
                    Card newCard = new Card (stringVal, suit, value);
                    cards.Add (newCard);
                    value++;
                }
            }
        }
        // Player Class 

    }
}