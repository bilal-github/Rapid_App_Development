using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal moneyEntered = Convert.ToDecimal(txtMoney.Text);
            moneyEntered = Math.Round(moneyEntered * 20) / 20; // so that change is to nearest nickel
            decimal moneyRemaining = moneyEntered;

            decimal TooniesCount =0;
            decimal LooniesCount =0;
            decimal QuartersCount=0;
            decimal DimesCount=0;
            decimal NickelsCount=0;
            decimal PenniesCount=0;

            //calculate toonies
            if (moneyRemaining >= 2m)
            {
                TooniesCount = Math.Truncate(moneyEntered / 2m);
                moneyRemaining = moneyEntered % 2;
            }

            //calculate loonies
            if (moneyRemaining >= 1m)
            {
                LooniesCount = Math.Truncate(moneyRemaining / 1m);
                moneyRemaining -= 1;
            }

            //calculate Qurters
            if (moneyRemaining >= 0.25m)
            {
                QuartersCount = Math.Truncate(moneyRemaining / 0.25m);
                moneyRemaining = moneyRemaining % 0.25m;

            }

            //calculate Dimes
            if (moneyRemaining >= 0.01m)
            {
                DimesCount = Math.Truncate(moneyRemaining / 0.1m);
                moneyRemaining = moneyRemaining % 0.1m;
            }

            //calculate Nickels
            if (moneyRemaining >= 0.05m)
            {
                NickelsCount = Math.Truncate(moneyRemaining / 0.05m);
                moneyRemaining = moneyRemaining % 0.05m;
            }

           //calculate Pennies
            //PenniesCount = Math.Truncate(moneyRemaining/0.01m);
            //moneyRemaining = moneyRemaining;





            if (TooniesCount < 0) TooniesCount = 0;
            if (LooniesCount < 0) LooniesCount = 0;
            if (QuartersCount < 0) QuartersCount = 0;
            if (DimesCount < 0) DimesCount = 0;
            if (NickelsCount < 0) NickelsCount = 0;
            if (PenniesCount < 0) PenniesCount = 0;





            txtToonies.Text = TooniesCount.ToString();
            txtLoonies.Text = LooniesCount.ToString();
            txtQuarters.Text = QuartersCount.ToString();
            txtDimes.Text = DimesCount.ToString();
            txtNickels.Text = NickelsCount.ToString();
            txtPennies.Text = PenniesCount.ToString();




        }
    }
}
