using Cards.Classes;
using Cards.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
    public class Card : ICard
    {
        internal Card(CardValue value, Suit suit)
        {
            throw new NotImplementedException();
        }

        public Suit Suit => throw new NotImplementedException();

        public CardValue Value => throw new NotImplementedException();

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
