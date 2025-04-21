using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string username, password, user = "Mehriban", pass = "admin";
        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;
            if (username == user && password==pass)
            {
                label3.Text = "Welcome to Computer";
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                label3.Text = "Sorry wrong";
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
