using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1_den_N_e_kadar_toplam
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, top,c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            Random s = new Random();
            c = s.Next(a, b);
            label8.Text = c.ToString();
            top = (c * (c + 1)) / 2;
            label6.Text = top.ToString();


            
        }
    }
}
