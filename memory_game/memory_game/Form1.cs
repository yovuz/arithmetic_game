using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] words = {

        "cat", "dog", "sun", "run", "pen",

            "box", "car", "red", "bed", "top",

            "man", "day", "sea", "fly", "ice",

            "old", "new", "key", "map", "row"
        };
        Random rnd = new Random();
        int time = 20, correct = 0, number;

        private void timer1_Tick(object sender, EventArgs e)
        {
            TextBox[] T = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };
            time -= 1;
            label10.Text = $"{time}";
            if (time == 0)
            {
                timer1.Stop();
                groupBox2.Visible = false;
                for (int i = 0; i <= 8; i++)
                    T[i].ReadOnly = false;
            }
        }
        void result()
        {
            if (correct == 9 || correct == 8)
                text = "excellent";
            else if (correct <= 7 && correct >=5)
                text = "good";
            else if (correct <=4)
                text = "poor";
            label12.Text = $"Your memory is {text}";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Label[] L = { label1, label2, label3, label4, label5, label6, label7, label8, label9 };
            TextBox[] T = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };
            for (int i = 0; i <= 8; i++)
            {
                if (T[i].Text == "")
                    T[i].BackColor = Color.Yellow;
                else if (T[i].Text == L[i].Text)
                    correct += 1;
                else
                    T[i].BackColor = Color.Red;
            }
            label11.Text = $"{correct}";
            progressBar1.Value = correct;
            groupBox2.Visible = true;
            button3.Enabled = true;
            result();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Label[] L = { label1, label2, label3, label4, label5, label6, label7, label8, label9 };
            TextBox[] T = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };
            for (int i = 0; i <= 8; i++)
            {
                L[i].Text = "0";
                T[i].BackColor = Color.White;
                T[i].Clear();
            }
            time = 20;
            correct = 0;
            label10.Text = "20";
            label11.Text = "0";
            label12.Text = "Result";

            progressBar1.Value = 0;
            button1.Enabled = true;
        }

        string text;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            Label[] L = { label1, label2, label3, label4, label5, label6, label7, label8, label9 };
            TextBox[] T = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };
            for (int i=0; i <= 8; i++)
            {
                number = rnd.Next(1, 21);
                L[i].Text = words[number];
                T[i].ReadOnly = true;
            }
            button1.Enabled = false;
            button3.Enabled = false;
        }
    }
}
