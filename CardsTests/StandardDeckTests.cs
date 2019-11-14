using Cards.Classes;
using Cards.Interfaces;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardsTests
{
    [TestClass]
    public class StandardDeckTests
    {
        [TestMethod]
        public void DeckCreation_TotalNumberOfCardsIs52()
        {
            IDeck deck = new StandardDeck();

            deck.CardCount.Should().Be(52);
        }

        [TestMethod]
        public void DealCard_OneCardIsReturned_DeckHasOneFewerCard()
        {
            IDeck deck = new StandardDeck(CreationShuffleOption.NotShuffled);

            var card = deck.DealCard();

            deck.CardCount.Should().Be(51);
        }

        [TestMethod]
        public void DealCards_CorrectNumberOfCardsReturned_DeckIsFewerByCorrectNumber()
        {
            IDeck deck = new StandardDeck(CreationShuffleOption.NotShuffled);

            var cards = deck.DealCards(5);

            deck.CardCount.Should().Be(47);
            cards.Count().Should().Be(5);
        }
    }
}
