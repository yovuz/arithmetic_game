using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number;
        string result;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                number = 0;
            }
            else
            {
                number = int.Parse(textBox1.Text);

            }
            listBox1.Items.Clear();
            for(int i=1; i < 11; i++)
            {
                result = $"{number}*{i}={number * i}";
                listBox1.Items.Add(result);
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
