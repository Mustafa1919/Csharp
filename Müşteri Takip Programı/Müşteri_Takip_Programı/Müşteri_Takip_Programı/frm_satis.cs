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
    public partial class frm_satis : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data source=C:\Users\TED\Desktop\Müşteri Takip Programı\KayıtlarVT.accdb");
        OleDbCommand cmd;
        public frm_satis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Select Musteri_ID from MüşteriKayıtları Where Ad=@ad and Soyad=@sad", con);
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@sad", textBox2.Text);
            int x = Convert.ToInt32(cmd.ExecuteScalar());
            cmd = new OleDbCommand("Select Urun_Kodu from Stok Where Urun_Adi=@uadi", con);
            cmd.Parameters.AddWithValue("@uadi", textBox4.Text);
            int y = Convert.ToInt32(cmd.ExecuteScalar());
            

            cmd = new OleDbCommand("insert into Satis(Urun_Adi,Musteri_IDfk,Urun_IDfk) values(@uadi,@mid,@uid)", con);
            cmd.Parameters.AddWithValue("@uadi", textBox4.Text);
            cmd.Parameters.AddWithValue("@mid", x);
            cmd.Parameters.AddWithValue("@uid", y);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();

        }
    }
}
