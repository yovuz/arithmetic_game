using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int player, comp;
        int jem1, jem2, round;

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            jem1 = 0;
            jem2 = 0;
            round = 0;
            label1.Text = "Player:0";
            label2.Text = "Computer:0";
            label3.Text = "Round:0";
            pictureBox1.ImageLocation = "redDice.gif";
            pictureBox2.ImageLocation = "redDice.gif";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player = rnd.Next(1, 7);
            comp= rnd.Next(1, 7);
            jem1 += player;
            jem2 += comp;
            label1.Text = $"Player:{jem1}";
            label2.Text = $"Computer:{jem2}";
            pictureBox1.ImageLocation = $"{player}.jpg";
            pictureBox2.ImageLocation = $"{comp}.jpg";
            round += 1;
            label3.Text = $"Round:{round}";
            if (round == 10)
            {
                button1.Enabled = false;
                if (jem1 > jem2)
                    label3.Text = "Player won!";
                else if (jem1 < jem2)
                    label3.Text = "Computer won!";
                else if (jem1==jem2)
                    label3.Text = "Friendship won!";
            }
        }
    }
}
