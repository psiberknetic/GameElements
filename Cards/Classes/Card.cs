using Cards.Classes;
using Cards.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
    public class Card : ICard
    {
        private readonly CardValue _value;
        private readonly Suit _suit;

        internal Card(CardValue value, Suit suit)
        {
            _value = value;
            _suit = suit;
        }

        public Suit Suit => _suit;

        public CardValue Value => _value;

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
