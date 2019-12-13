using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            lblCurrentDate.Text = DateTime.Today.ToShortDateString();
            lblCurrentTime.Text = DateTime.Now.ToShortTimeString();
            //
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Today.ToLongDateString();
            lblCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime partyDate = dateTimePicker1.Value.Date;//selected date
            lblMessage.Text = " The party is on " + partyDate.ToLongDateString();

            //how long do we need to wait for the party
            DateTime today = DateTime.Today;//current date
            //calculate difference in dayas
            TimeSpan ts = partyDate.Subtract(today);
            int days = ts.Days;
            if(days < 0)
            {
                lblMessage.Text += "\n Sorry, you missed the party : it was " + -days + " day(s) ago";
                lblMessage.ForeColor = System.Drawing.Color.Red;

            }
            else if(days > 0)
            {
                lblMessage.Text += "\n" + days + " more day(s)";
                lblMessage.ForeColor = System.Drawing.Color.Green;


            }
            else
            {
                lblMessage.Text += "\n Run to the party, you are gonna miss it";
                lblMessage.ForeColor = System.Drawing.Color.Yellow;

            }

        }
    }
}
