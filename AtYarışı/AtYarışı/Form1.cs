using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int at1sol, at2sol, at3sol, at4sol;
        Random rnd = new Random();
        int sayı;
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int at1gen = pictureBox1.Width;
            int at2gen = pictureBox3.Width;
            int at3gen = pictureBox2.Width;
            int at4gen = pictureBox4.Width;

            int finish = label6.Left;

            sayı=Int32.Parse(label12.Text);
            sayı++;
            label12.Text = sayı.ToString();

            pictureBox1.Left += rnd.Next(5, 12);
            pictureBox2.Left += rnd.Next(5, 12);
            pictureBox3.Left += rnd.Next(5, 12);
            pictureBox4.Left += rnd.Next(5, 12);

            if (at1gen + pictureBox1.Left >= finish)
            {
                timer1.Enabled = false;
                listBox1.Items.Add("1. Poyraz Yeli"+sayı+"sanise");
            }
            if (at2gen + pictureBox3.Left >= finish)
            {
                timer1.Enabled = false;
                listBox1.Items.Add("1. Sütçü Beygiri" + sayı + "sanise");
            }
            if (at3gen + pictureBox2.Left >= finish)
            {
                timer1.Enabled = false;
                listBox1.Items.Add("1. Kanlıtay" + sayı + "sanise");
            }
            if (at4gen + pictureBox4.Left >= finish)
            {

                timer1.Enabled = false;
                listBox1.Items.Add("1. Kızık Beyi" + sayı + "sanise");
            }
            if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left && pictureBox1.Left > pictureBox4.Left)
                label11.Text = "Poyraz Yeli Yarışı Önde Götürüyor";

            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left && pictureBox2.Left > pictureBox4.Left)
                label11.Text = "Kanlıtay Müthiş Bir Atağa Kalkıyor";

            if (pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox1.Left && pictureBox1.Left > pictureBox4.Left)
                label11.Text = "Sütçü Beygiri Yine Yaptı Yapacağını";

            if (pictureBox4.Left > pictureBox2.Left && pictureBox4.Left > pictureBox3.Left && pictureBox4.Left > pictureBox1.Left)
                label11.Text = "Kızık Beyi Şaha Kalkıyor ve Öne Geçiyor";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            at1sol = pictureBox1.Left;
            at2sol = pictureBox3.Left;
            at3sol = pictureBox2.Left;
            at4sol = pictureBox4.Left;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
