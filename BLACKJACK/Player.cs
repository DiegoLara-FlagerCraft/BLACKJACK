using System;
using System.Collections.Generic;
using System.Text;

namespace BLACKJACK
{
    class Player
    {
        // Almacena las cartas del jugador

        public List<Card> hand;
        public List<Card> Hand { get => hand; set => hand = value; }

        public void AddCard()
        {
            //Recibe una carta y la agrega a la mano del jugador 
        }


        public void Init()
        {
            // Invoca dos veces al metodo Deal y agrega las cartas al hand utilizando el metodo AddCard
        }
    }
}
