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
    public partial class Form3 : Form
    {
        int a;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = (100 * 101) / 2;
            label3.Text = a.ToString();
        }
    }
}
