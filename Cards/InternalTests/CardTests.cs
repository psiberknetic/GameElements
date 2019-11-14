using Cards.Classes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.InternalTests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void ToString_FormattedCorrectly()
        {
            var card = new Card(CardValue.Ace, Suit.Hearts);

            card.ToString().Should().Be("Ace of Hearts");
        }
    }
}
