using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Names = File.ReadAllLines("Names.txt");
        string city, input;
        int index, count, chance, correct;

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToLower() == city)
            {
                foreach(Label i in panel1.Controls)
                {
                    i.BackColor = Color.Green;
                    i.ForeColor = Color.White;
                }
                MessageBox.Show($"You Won");
                correct += 1;
                label3.Text = $"Correct: {correct}";
            }
            else
            {
                MessageBox.Show($"You Lost! Answer is {city}");
            }
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input = textBox1.Text.ToLower();
            control = false;

            foreach(Label i in panel1.Controls)
            {
                if (input == i.Text)
                {
                    i.BackColor = Color.Green;
                    i.ForeColor = Color.White;
                    count += 1;
                    control = true;
                }
            }
            if (control == false)
            {
                chance -= 1;
                label2.Text = $"Chance: {chance}";

                if (chance == 0)
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    MessageBox.Show($"You Lost! Answer is {city}");
                }
            }
            if (count == city.Length)
            {
                button2.Enabled = false;
                button3.Enabled = false;

                MessageBox.Show($"You Won");

                correct += 1;
                label3.Text=$"Correct:{correct}";
            }
            label1.Text += $"{input}";
            textBox1.Clear();
            textBox1.Focus();
        }

        bool control;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            index = rnd.Next(Names.Length);
            city = Names[index];
            for(int i=0;i<city.Length; i++)
            {
                Label letter = new Label();
                letter.Text = city[i].ToString();

                letter.Location = new Point(20 + i * 30, 20);
                letter.Size = new System.Drawing.Size(25, 25);

                letter.Font = new System.Drawing.Font("Calibri", 14);
                letter.ForeColor = Color.Red;
                letter.BackColor = Color.Red;

                panel1.Controls.Add(letter);
            }
            button2.Enabled = true;
            button3.Enabled = true;

            chance = 5;
            count = 0;

            label1.Text = "Entered:";
            label2.Text = "Chance: 5";

            textBox2.Clear();
        }
    }
}
