using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double tnet, snet, mnet, fnet;

        private void button2_Click(object sender, EventArgs e)
        {
            tnet = Convert.ToDouble(textBox1.Text) - (0.25 * Convert.ToDouble(textBox2.Text));
            label8.Text = tnet.ToString();
            snet = Convert.ToDouble(textBox3.Text) - (0.25 * Convert.ToDouble(textBox4.Text));
            label9.Text = snet.ToString();
            mnet = Convert.ToDouble(textBox5.Text) - (0.25 * Convert.ToDouble(textBox6.Text));
            label10.Text = mnet.ToString();
            fnet = Convert.ToDouble(textBox7.Text) - (0.25 * Convert.ToDouble(textBox8.Text));
            label11.Text = fnet.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tnet = Convert.ToDouble(textBox1.Text) - (0.25 * Convert.ToDouble(textBox2.Text));
            snet = Convert.ToDouble(textBox3.Text) - (0.25 * Convert.ToDouble(textBox4.Text));
            mnet = Convert.ToDouble(textBox5.Text) - (0.25 * Convert.ToDouble(textBox6.Text));
            fnet = Convert.ToDouble(textBox7.Text) - (0.25 * Convert.ToDouble(textBox8.Text));


            label18.Text = (100.160 + (tnet * 1.999) + (snet * 1) + (mnet * 3.998) + (fnet * 2.999)).ToString();
            label19.Text = (100.160 + (tnet * 1.999) + (snet * 1) + (mnet * 2.999) + (fnet * 3.998)).ToString();
            label20.Text = (100.160 + (tnet * 3.998) + (snet * 2.999) + (mnet * 1.999) + (fnet * 1)).ToString();
            label21.Text = (100.160 + (tnet * 2.999) + (snet * 3.998) + (mnet * 1.999) + (fnet * 1)).ToString();
            label22.Text = (100.120 + (tnet * 3.699) + (snet * 1.999) + (mnet * 3.299) + (fnet * 1)).ToString();
            label23.Text = (100.120 + (tnet * 3.299) + (snet * 1) + (mnet * 3.699) + (fnet * 1.999)).ToString();
        }
    }
}
/*
+/ ygs1=100.160+(türkçe*1,999)+(sosyal*1)+(matematik*3.998)+(fen*2.999)

+/ ygs2=100.160+(türkçe*1,999)+(sosyal*1)+(matematik*2.999)+(fen*3.998)

+/ ygs3=100.160+(türkçe*3.998)+(sosyal*2.999)+(matematik*1.999)+(fen*1)

+/ ygs4=100.160+(türkçe*2,999)+(sosyal*3.998)+(matematik*1.999)+(fen*1)

+/ ygs5=100.120+(türkçe*3.699)+(sosyal*1.999)+(matematik*3.299)+(fen*1)

+/ ygs6=100.120+(türkçe*3.299)+(sosyal*1)+(matematik*3.699)+(fen*1.999)
 */