using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffler
{
    public class Deck
    {
        private Card[] deck; // array of card objects
        private int currentCard;
        private Random random; // 
        
        public Deck()
        {
            string[] suits = { "\u2666", "\u2665", "\u2663", "\u2660" };
            string[] rank = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            deck = new Card[52]; // creates array of Card objects
            currentCard = 0;
            random = new Random();

            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(rank[count % 13], suits[count/13]);

                
            }
        }
        

        public void Shuffle()
        {
            currentCard = 0;

            for (int initial = 0; initial < deck.Length; initial++)
            {
                int nextNumber = random.Next(52); // select random 0-51

                //swap current with the random card
                Card newCard = deck[initial];
                deck[initial] = deck[nextNumber];
                deck[nextNumber] = newCard;
                

            }
        }

        public Card ShuffleEachCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
        
    }

}






