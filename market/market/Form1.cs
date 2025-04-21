using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, int> Grocery = new Dictionary<string, int>()
        {
            {"apple",11},
            {"tomato",8},
            {"orange",14},
            {"banana",29},
            {"pepper",18},
            {"cucumber",12}
        };
        string type;
        double quantity, money1, money2, basket, pay;

        private void button3_Click(object sender, EventArgs e)
        {
            basket = 0;
            pay = 0;
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
            button1.Enabled = true;
            label7.Text = "Money1";
            label8.Text = "Money2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            money2 = double.Parse(textBox2.Text);
            pay += money2;
            if (pay == basket)
                label8.Text = "Thanks for shopping";
            else if (pay < basket)
                label8.Text = $"TPayed: {pay} m\n"
                    + $"Add: {basket - pay} m";
            else if (pay > basket)
                label8.Text = "Thanks for shopping \n"
                    + $"Refund: {pay - basket} m";
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            type = comboBox1.Text;
            quantity = double.Parse(textBox1.Text);
            money1 = Grocery[type] * quantity;
            basket += money1;
            label7.Text = $"Money due: {basket} m";
            listBox1.Items.Add($"{type}-{quantity}kg -{money1} m");
        }
    }
}
