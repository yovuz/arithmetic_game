using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            c1 = 0;
            c2 = 0;
            c3 = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label5.Text = "Money Earned";
        }
        int c1, c2, c3;

        private void button3_Click(object sender, EventArgs e)
        {
            c2 += 1;
            textBox3.Text = c2.ToString();
            textBox4.Text = $"{c2 * 15} manats";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c3 += 1;
            textBox5.Text = c3.ToString();
            textBox6.Text = $"{c3 * 5} manats";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = $"Money Earned: {c1 * 50 + c2 * 15 + c3 * 5} manats";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c1 > 0)
            {
                c1 -= 1;
                textBox1.Text = c1.ToString();
                textBox2.Text = $"{c1 * 50} manats";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c1 < 30)
            {
                c1 += 1;
                textBox1.Text = c1.ToString();
                textBox2.Text =$"{ c1*50} manats";
            }
        }
    }
}
