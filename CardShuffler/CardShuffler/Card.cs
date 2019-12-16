using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffler
{
    public class Card
    {
        // private int cardNumber;
        // private int numberOfCards;

        private string suit { get; set; }
        private string rank { get; set; }



        public Card(string cardRank, string cardSuit)
        {
            rank = cardRank;
            suit = cardSuit;
        }

        public override string ToString()
        {
            return suit + rank;
        }


    }
}
