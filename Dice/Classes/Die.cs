using System;
using System.Collections.Generic;
using System.Text;

namespace Dice
{
    public class Die : IDie
    {
        public Die(int sides)
        {
            if (sides <= 0)
            {
                throw new ArgumentException("Sides must be greater than zero", "sides");
            }

            _sides = sides;
        }

        private Random _random = new Random();
        private int _sides;
        private int _value;

        public int Value => _value;

        public int Sides => _sides;

        public IDie Roll()
        {
            _value = _random.Next(1, _sides);
            return this;
        }
    }
}
