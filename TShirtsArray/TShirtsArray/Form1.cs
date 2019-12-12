using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TShirtsArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWinning_Click(object sender, EventArgs e)
        {
            int[,] sales = new int[,] { { 345, 564, 1245, 1690 }, { 1232, 1534, 795, 238 }, { 1189, 1387, 987, 546 } };

            int total = 0;
            int row1 = 0;
            int row2 = 0;
            int row3 = 0;

            Console.WriteLine(sales.GetLength(0));
            Console.WriteLine(sales.GetLength(1));
            //for (int r=0; r <= 2; r++)
            //{
            for (int c = 0; c <= 3; c++)
            {

                row1 = row1 + sales[0, c];
                row2 = row2 + sales[1, c];
                row3 = row3 + sales[2, c];
            }
            txtBlack.Text = row1.ToString();
            txtWhite.Text = row2.ToString();
            txtRed.Text = row3.ToString();

            int max = Math.Max(Math.Max(row1, row2), row3);

            if (max == row1)
            {
                lblWin.Text = "Black";
            }else if(max == row2)
            {
                lblWin.Text = "White";
            }
            else
            {
                lblWin.Text = "Red";
            }

            txtWin.Text = max.ToString();


            //}

        }
    }
}
