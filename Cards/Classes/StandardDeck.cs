using Cards.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards.Classes
{
    public class StandardDeck : IDeck
    {
        private IList<Card> _cards;

        public StandardDeck(CreationShuffleOption creationShuffleOption = CreationShuffleOption.Shuffled)
        {
            _cards = new List<Card>(from suit in (Suit[])Enum.GetValues(typeof(Suit))
                                    from cardValue in (CardValue[])Enum.GetValues(typeof(CardValue))
                                    select new Card(cardValue, suit));

            if (creationShuffleOption == CreationShuffleOption.Shuffled)
            {
                Shuffle();
            }
        }

        public int CardCount => _cards.Count();

        public ICard DealCard()
        {
            var card = _cards.First();
            _cards.RemoveAt(0);

            return card;
        }

        public IEnumerable<ICard> DealCards(int numberToDeal)
        {
            var cards = _cards.Take(numberToDeal).ToList();
            for (int i = 0; i < numberToDeal; i++)
            {
                _cards.RemoveAt(0);
            }

            return cards;
        }

        public void Shuffle()
        {
            var rand = new Random();
            var shuffledDeck = new List<Card>();
            while (_cards.Count() > 0)
            {
                var randomIndex = rand.Next(0, _cards.Count() - 1);
                shuffledDeck.Add(_cards.ElementAt(randomIndex));
                _cards.RemoveAt(randomIndex);
            }

            _cards = shuffledDeck;
        }
    }
}
