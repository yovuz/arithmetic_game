using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int M, S, F;
        double Avr;
        private void button1_Click(object sender, EventArgs e)
        {
            M = int.Parse(textBox1.Text);
            S = int.Parse(textBox2.Text);
            F = int.Parse(textBox3.Text);
            Avr = S * 0.25 + M * 0.3 + F * 0.45;
            if (S>=50 && F>=50 && M >= 50)
            {
                label5.Text = "You passed! Average is :" + Avr;
                label5.ForeColor = Color.Green;

            }
            else
            {
                label5.Text = "You failed is :" + Avr;
                label5.ForeColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        0

        }
    }
}
