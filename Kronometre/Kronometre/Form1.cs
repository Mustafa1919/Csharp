using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        int x;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 0;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label1.Text);
            label1.Text = "0";
            timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x + 1;
            label1.Text = x.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

       

       
    }
}
