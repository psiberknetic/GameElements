using System;
using System.Collections.Generic;
using System.Text;

namespace Dice
{
    public interface IDie
    {
        IDie Roll();

        Guid Id { get; }
        int Value { get; }
        int Sides { get; }
    }
}
