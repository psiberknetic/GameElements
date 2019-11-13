using System;
using System.Collections.Generic;
using System.Text;

namespace Dice
{
    public interface IDie
    {
        IDie Roll();

        int Value { get; }
        int Sides { get; }
    }
}
