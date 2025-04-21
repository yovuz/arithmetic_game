using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int user,odd=0,even=0;

        private void button2_Click(object sender, EventArgs e)
        {
            even = 0;
            odd = 0;
            label1.Text = "Odd:0";
            label2.Text = "Even:0";
            textBox1.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = int.Parse(textBox1.Text);
            if (user % 2 == 0)
            {
                even += user;
                label2.Text = $"Even:{even}";
                textBox1.Clear();
            }
            else if (user % 2 != 0)
            {
                odd += user;
                label1.Text = $"Odd:{odd}";
                textBox1.Clear();
            }
        }
    }
}
