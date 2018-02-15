using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsharpRandomLig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int p1, p2, p3, p4;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Lütfen Takımları Giriniz!!");
            else
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                label3.Text = textBox1.Text;
                label4.Text = textBox2.Text;
                label17.Text = textBox3.Text;
                label16.Text = textBox4.Text;

                label12.Text = textBox1.Text;
                label22.Text = textBox2.Text;
                label11.Text = textBox3.Text;
                label21.Text = textBox4.Text;

                label32.Text = textBox1.Text;
                label27.Text = textBox2.Text;
                label26.Text = textBox3.Text;
                label31.Text = textBox4.Text;

                label37.Text = textBox1.Text;
                label38.Text = textBox2.Text;
                label39.Text = textBox3.Text;
                label40.Text = textBox4.Text;
                button1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(0, 6);
            int b = rnd.Next(0, 6);
            int c = rnd.Next(0, 6);
            int d = rnd.Next(0, 6);

            label5.Text = a.ToString();
            label7.Text = b.ToString();
            label15.Text = c.ToString();
            label13.Text = d.ToString();

            label43.Text = "1";
            label44.Text = "1";
            label45.Text = "1";
            label46.Text = "1";
            button2.Visible = false;

            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label7.Text))
                p1 += 3;
            else if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label5.Text))
                p2 += 3;
            else
            {
                p1 += 1;
                p2 += 1;
            }

            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label13.Text))
                p3 += 3;
            else if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label15.Text))
                p4 += 3;
            else
            {
                p3 += 1;
                p4 += 1;
            }

            label47.Text = p1.ToString();
            label48.Text = p2.ToString();
            label49.Text = p3.ToString();
            label50.Text = p4.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(0, 6);
            int b = rnd.Next(0, 6);
            int c = rnd.Next(0, 6);
            int d = rnd.Next(0, 6);

            label10.Text = a.ToString();
            label8.Text = b.ToString();
            label20.Text = c.ToString();
            label18.Text = d.ToString();

            label43.Text = "2";
            label44.Text = "2";
            label45.Text = "2";
            label46.Text = "2";
            button3.Visible = false;

            if (Convert.ToInt32(label10.Text) > Convert.ToInt32(label8.Text))
                p1 += 3;
            else if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label10.Text))
                p3 += 3;
            else
            {
                p1 += 1;
                p3 += 1;
            }

            if (Convert.ToInt32(label20.Text) > Convert.ToInt32(label18.Text))
                p2 += 3;
            else if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label20.Text))
                p4 += 3;
            else
            {
                p2 += 1;
                p4 += 1;
            }

            label47.Text = p1.ToString();
            label48.Text = p2.ToString();
            label49.Text = p3.ToString();
            label50.Text = p4.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(0, 6);
            int b = rnd.Next(0, 6);
            int c = rnd.Next(0, 6);
            int d = rnd.Next(0, 6);

            label23.Text = a.ToString();
            label25.Text = b.ToString();
            label28.Text = c.ToString();
            label30.Text = d.ToString();

            label43.Text = "3";
            label44.Text = "3";
            label45.Text = "3";
            label46.Text = "3";
            button4.Visible = false;
            button5.Visible = true;

            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label28.Text))
                p1 += 3;
            else if (Convert.ToInt32(label28.Text) > Convert.ToInt32(label30.Text))
                p4 += 3;
            else
            {
                p1 += 1;
                p4 += 1;
            }

            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label23.Text))
                p2 += 3;
            else if (Convert.ToInt32(label23.Text) > Convert.ToInt32(label25.Text))
                p3 += 3;
            else
            {
                p2 += 1;
                p3 += 1;
            }

            label47.Text = p1.ToString();
            label48.Text = p2.ToString();
            label49.Text = p3.ToString();
            label50.Text = p4.ToString();

            
            if (p1>p2 && p1>p3 && p1>p4)
                MessageBox.Show(textBox1.Text,"Şampiyon");
            else if (p2>p3 && p2>p4)
                MessageBox.Show(textBox2.Text,"Şampiyon");
            else if (p3>p4)
                MessageBox.Show(textBox3.Text,"Şampiyon");
            else
                MessageBox.Show(textBox4.Text,"Şampiyon");
                


           
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = false;
            label43.Text = "0";
            label44.Text = "0";
            label45.Text = "0";
            label46.Text = "0";
            p1 = 0;
            p2 = 0;
            p3 = 0;
            p4 = 0;
            label47.Text = "0";
            label48.Text = "0";
            label49.Text = "0";
            label50.Text = "0";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
        
    }
}
