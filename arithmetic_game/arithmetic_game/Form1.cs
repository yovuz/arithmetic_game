using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int a, b, correct, question, input, time;

        private void button2_Click(object sender, EventArgs e)
        {
            input = int.Parse(textBox1.Text);
            if (input == a + b)
            {
                correct += 1;
                label4.Text = $"Correct:{correct}";
            }
            question += 1;
            label3.Text = $"Question:{question}";
            textBox1.Clear();
            textBox1.Focus();
            create_question();
        }

        void create_question()
        {
            a = rnd.Next(10, 51);
            b = rnd.Next(10, 51);
            label2.Text = $"{a}+{b}=";

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time -= 1;
            label5.Text = time.ToString();
            if (time == 0)
            {
                timer1.Stop();
                button2.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            create_question();
            time = 60;
            correct = 0;
            question = 0;
            button2.Enabled = true;
            label3.Text = "Question:0";
            label4.Text = "Correct:0";

        }

    }
}
