using Cards.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Interfaces
{
    public interface ICard
    {
        Suit Suit { get; }
        CardValue Value { get; }
    }
}
