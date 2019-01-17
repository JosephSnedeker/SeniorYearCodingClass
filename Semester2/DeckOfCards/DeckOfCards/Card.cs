using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Card
    {
        private string Suit;
        private int Value;
        public Card(string Suit, int Value)
        {
            this.Value = Value;
            this.Suit = Suit;

        }
    }
}
