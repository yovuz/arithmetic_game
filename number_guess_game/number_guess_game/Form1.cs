using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            guess = int.Parse(textBox1.Text);
            if (number == guess)
            {
                label2.Text = "You won!";
                button2.Enabled = false;
            }
            else if (number < guess)
            {
                label2.Text = "Your guess number is high";
                chance -= 1;
            }
            else if(number>guess)
            {
                label2.Text = "Your guess number is small";
                chance -= 1;
            }
            if (chance == 0)
            {
                label2.Text = $"You lost! answer is {number}";
                button2.Enabled = false;
            }
        }
        Random rnd = new Random();
        int number, guess, chance = 3;

        private void button3_Click(object sender, EventArgs e)
        {
            number = rnd.Next(1, 11);
            textBox1.Clear();
            button2.Enabled = true;
            label2.Text = "Result";
            chance = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            number = rnd.Next(1, 11);
        }
    }
}
