using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Müşteri_Takip_Programı
{
    public partial class frm_borc : Form
    {
        public frm_borc()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data source=C:\Users\TED\Desktop\Müşteri Takip Programı\KayıtlarVT.accdb");
        OleDbCommand cmd;


        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("Update Borç set Borc=Borc+@borc where Ad=@ad and Soyad=@soyad", con);
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
            cmd.Parameters.AddWithValue("@borc", textBox3.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("Update Borç set Borc=Borc-@borc where Ad=@ad and Soyad=@soyad", con);
            cmd.Parameters.AddWithValue("@ad", textBox4.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox5.Text);
            cmd.Parameters.AddWithValue("@borc", textBox6.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Select Musteri_ID from MüşteriKayıtları Where Ad=@ad and Soyad=@sad", con);
            cmd.Parameters.AddWithValue("@ad", textBox7.Text);
            cmd.Parameters.AddWithValue("@sad", textBox8.Text);
            int x = Convert.ToInt32(cmd.ExecuteScalar());

            cmd = new OleDbCommand("insert into Borç(Ad,Soyad,Borc,Musteri_IDsk) values(@ad,@soyad,@borc,@msk)", con);
            cmd.Parameters.AddWithValue("@ad", textBox7.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox8.Text);
            cmd.Parameters.AddWithValue("@borc", textBox9.Text);
            cmd.Parameters.AddWithValue("@msk", x);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            
        }
    }
}
