using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SıkıysaYakala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();

            int en = rnd1.Next(0, this.Width - button1.Left);
            int boy = rnd2.Next(0, this.Height - button1.Top);

            button1.Left = en;
            button1.Top = boy;
        }
    }
}
