using Cards.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Classes
{
    public class StandardDeck : IDeck
    {
        public StandardDeck(CreationShuffleOption creationShuffleOption = CreationShuffleOption.Shuffled)
        {
            throw new NotImplementedException();
        }

        public int CardCount => throw new NotImplementedException();

        public ICard DealCard()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICard> DealCards(int numberToDeal)
        {
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
