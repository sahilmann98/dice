using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbxdiceroll_Click(object sender, EventArgs e)
        {
            //define a random generator with aillisecond as the seed
            Random myrandom = new Random(DateTime.Now.Millisecond);

            //define the variables that will set valves with the initial value as 0 
            int dice1, dice2, dice3 = 0;
            int counter = 0;
            //we need a oolean,(true,false) to tell us when the values match
            bool rolldiceagain = true;
            listBox1.Items.Clear();
            do//condition for rolling the dice

            {
                dice1 = myrandom.Next(1, 7);
                dice2 = myrandom.Next(1, 7);
                dice3 = myrandom.Next(1, 7);
                //add the values of dice to the listbox as a new item
                listBox1.Items.Add("dice1 =  " + dice1 + "" + "dice2 =  " + dice2 + "dice3 =" + dice3);//
                counter++;
                lblcounter.Text = (" there were " + counter.ToString() + "rolls");
                this.lblcounter.Font = new Font("calibri", 20);
                if ((dice1 == dice2) && (dice2 == dice3))
                {
                    rolldiceagain = false;
                }
            } while (rolldiceagain == true);


        }

        private void Lblcounter_Click(object sender, EventArgs e)
        {

        }
    }
}

