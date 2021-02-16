using System;
using System.Collections.Generic;
using System.Text;

namespace GenericHW
{
    public class Player
    {
        public List<Card> cards = new List<Card>();
    }

    public enum CardValue
    {
        SIX = 0, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
    }

    public enum CardSuit
    {
        HEARTS = 0, DIAMONDS, CLUBS, SPADES
    }
    public class Card
    {

        public readonly CardValue value;
        public readonly CardSuit suit;

        public Card(CardValue value, CardSuit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{value} {suit}";
        }
    }
}
