using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double W, H, B;
        private void button1_Click(object sender, EventArgs e)
        {
            W = double.Parse(textBox1.Text);
            H = double.Parse(textBox2.Text);
            B = (W / (H * H));
            if (B < 18.5)
            {
                label5.Text = "Underweight" + B;
            }
            else if(B>=18.5 && B< 25){
                label5.Text = "Normal" + B;
            }
            else if (B >=25 && B < 30){
                label5.Text = "Overweight" + B;
            }
            else if (B >= 30 && B < 35)
            {
                label5.Text = "Overweight" + B;
            }
            else if (B<35){
                label5.Text = B.ToString();
            }
        }
    }
}
