using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Interfaces
{
    public interface IDeck
    {
        void Shuffle();

        ICard DealCard();

        IEnumerable<ICard> DealCards(int numberToDeal);

        int CardCount { get; }
    }
}
