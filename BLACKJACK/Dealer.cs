using System;
using System.Collections.Generic;
using System.Text;

namespace BLACKJACK
{
    class Dealer
    {
        // Almacena todas las cartas
        public List<Card> deck;
        public List<Card> Deck { get => deck; set => deck = value; }

        // Almacena las cartas del tallador
        public List<Card> hand;
        public List<Card> Hand { get => hand; set => hand = value; }


        public void Generate()
        {
            Deck = new List<Card>();

            string[] suits = { "♥", "♦", "♣", "♠" };
            string[] symbols = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            // se deben generar las 52 cartas combinando los suits con los symbols

             
        }

        public void Randomize()
        {
            // desordena y modifica la lista o arreglo
        }


        public void Deal()
        {
            // Elimina una carta
        }


        public void AddCard()
        {
            //Recibe una carta y la agrega a la mano del dealer 
        }


        public void Init()
        {
            // Invoca dos veces al metodo Deal y agrega las cartas al hand utilizando el metodo AddCard
        }


    }
}
