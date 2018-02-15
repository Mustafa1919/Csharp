using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadyoCsharp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int sayaç;

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyoavrasya.radyolarburada.com:1071";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://dygwebradios.radyotvonline.com:80/dyg/kworld.stream/radyodelisi.m3u8";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.210:80";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://sh.mncdn.com:8092";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://sc.powergroup.com.tr:80/PowerTurk/aac/128/home";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.231:80";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://95.211.162.32:8014";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.turkuradyo.net:4591";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            sayaç++;
            label3.Text = sayaç.ToString();
               

            
            if (sayaç == x)
                Application.Exit();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer1.Start();
        }
    }
}
