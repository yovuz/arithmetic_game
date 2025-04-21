using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int factorial = 1, number;

            number = int.Parse(textBox1.Text);
            if (number == 0)
            {
                label1.Text = $"Result: 1";

            }
            else if (number > 0) {
                for (int i = 2; i < number + 1; i++)
                {
                    factorial *= i;
                }
                label1.Text = $"Result:{factorial}";
            }
            
            textBox1.Clear();
        }
    }
}
