using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BramlittJoshua_Integrative
{
    class Card
    {
        public string Suit { get; set; }
        public int Value { get; set; }

        public Card(string suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}   ";
        }
    }
}
