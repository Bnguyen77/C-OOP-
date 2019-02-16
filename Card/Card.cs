using System;
// using System.Linq;


namespace Card
{
    // Card Class
     public class Card {
        public string StringVal { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }
        public Card (string stringVal, string suit, int value) {
            StringVal = stringVal;
            Suit = suit;
            Value = value;
        }
    }
}