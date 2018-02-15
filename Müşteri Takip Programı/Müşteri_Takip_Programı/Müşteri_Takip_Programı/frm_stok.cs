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
    public partial class frm_stok : Form
    {
        public frm_stok()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data source=C:\Users\TED\Desktop\Müşteri Takip Programı\KayıtlarVT.accdb");
        OleDbCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("insert into Stok(Urun_Adi,Urun_Sayisi) values(@uadi,@uadedi)", con);
            cmd.Parameters.AddWithValue("@uadi", textBox1.Text);
            cmd.Parameters.AddWithValue("@uadedi", textBox2.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("Update Stok set Urun_Sayisi=Urun_Sayisi+@usayi where Urun_Adi=@uadi", con);
            cmd.Parameters.AddWithValue("@usayi", textBox4.Text);
            cmd.Parameters.AddWithValue("@uadi", textBox3.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("Update Stok set Urun_Sayisi=Urun_Sayisi-@usayi where Urun_Adi=@uadi", con);
            cmd.Parameters.AddWithValue("@usayi", textBox4.Text);
            cmd.Parameters.AddWithValue("@uadi", textBox3.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
