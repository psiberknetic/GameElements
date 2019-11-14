using Cards.Classes;
using Cards.Interfaces;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
    }
}
