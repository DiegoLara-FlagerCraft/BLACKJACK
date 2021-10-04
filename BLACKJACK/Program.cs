using System;

namespace BLACKJACK
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card("DAS","DSAD");

            Console.WriteLine(card.Suit + card.Symbol);
        }
    }
}
