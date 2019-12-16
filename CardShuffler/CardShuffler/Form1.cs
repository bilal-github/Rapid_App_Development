using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardShuffler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public enum Rank
        //{
        //    Ace = 1, Two, Three, Four, Five,
        //    Six, Seven, Eight, Nine, Ten, Jack, Queen, King
        //}
        //public enum Suit { Diamond = 1, Club, Heart, Spade }


        //Card[] cards = new Card[52];




        private void Form1_Load(object sender, EventArgs e)
        {
            Deck newDeck = new Deck();
            for (int i = 0; i < 52; i++)
            {
                lstCards.Items.Add(newDeck.ShuffleEachCard());

            }

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            lstCards.Items.Clear();
            Deck newdeck = new Deck();
            newdeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                lstCards.Items.Add(newdeck.ShuffleEachCard());
            }
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            lstCards.Items.Clear();
            Deck newdeck = new Deck();
            newdeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                //if ((i + 1) % 13 == 0)
                //{
                if (i == 0)
                {
                    lstCards.Items.Add("  Player:1");
                }
                else if (i == 13)
                {
                    lstCards.Items.Add("\n");
                    lstCards.Items.Add("  Player:2");
                }
                else if (i == 26)
                {
                    lstCards.Items.Add("\n");
                    lstCards.Items.Add("  Player:3");
                }
                else if (i == 39)
                {
                    lstCards.Items.Add("\n");
                    lstCards.Items.Add("  Player:4");
                }

                //}
                lstCards.Items.Add(newdeck.ShuffleEachCard());


            }
        }
    }

}



// lstCards.Items.Add(newDeck);

//foreach (Suit suit in Enum.GetValues(typeof(Suit)))
//{
//    lstCards.Items.Add(suit);
//    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
//    {
//        lstCards.Items.Add("\n  " + rank);
//        Random random = new Random();

//    }
//}








