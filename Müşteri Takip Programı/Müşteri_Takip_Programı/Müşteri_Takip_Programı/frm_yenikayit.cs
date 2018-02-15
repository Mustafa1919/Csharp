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
    public partial class frm_yenikayit : Form
    {
        public frm_yenikayit()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data source=C:\Users\TED\Desktop\Müşteri Takip Programı\KayıtlarVT.accdb");
        OleDbCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("insert into MüşteriKayıtları(Ad,Soyad,Adres,Telefon) values(@ad,@soyad,@tel,@adres)", con);
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
            cmd.Parameters.AddWithValue("@tel", textBox3.Text);
            cmd.Parameters.AddWithValue("@adres", textBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
        }
    }
}
