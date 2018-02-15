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
    public partial class Form2 : Form
    {
        int a,b;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = (a * (a + 1)) / 2;
            label3.Text = b.ToString();
        }
    }
}
