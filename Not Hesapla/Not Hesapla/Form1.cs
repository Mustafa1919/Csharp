using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Not_Hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fn;
            int a;
            a = Convert.ToInt32(textBox1.Text);
            fn = (60 - (a * 0.4)) * 10 / 6;
            if (fn < 50)
                label3.Text = "50";
            else
                label3.Text = fn.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ort;
            ort = (int.Parse(textBox1.Text) * 0.4) + (int.Parse(textBox2.Text) * 0.6);
            label4.Text = ort.ToString();
        }
    }
}
