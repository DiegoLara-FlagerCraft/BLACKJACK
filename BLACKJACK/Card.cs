using System;
using System.Collections.Generic;
using System.Text;

namespace BLACKJACK
{
    class Card
    {
        public string Suit { get; set; }
        public string Symbol { get; set; }

        public Card(string Suit, string Symbol)
        {
            this.Suit = Suit;
            this.Symbol = Symbol;

        }
    }
}
