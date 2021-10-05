using System;
using System.Collections.Generic;
using System.Text;

namespace BLACKJACK
{
    class Dealer
    {
        public List<Card> deck;
        public List<Card> Deck { get => deck; set => deck = value; }


        public void Generate()
        {
            Deck = new List<Card>();

            string[] suits = { "♥", "♦", "♣", "♠" };
            string[] symbols = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
             
        }


    }
}
