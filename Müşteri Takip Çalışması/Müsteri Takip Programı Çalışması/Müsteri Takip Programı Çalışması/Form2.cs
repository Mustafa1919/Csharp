using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Müsteri_Takip_Programı_Çalışması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data source=C:\Users\Ted\Desktop\Müşteri Takip Çalışması\kayıtlar.accdb");
            OleDbCommand cmd = new OleDbCommand("insert into kayıtlar(isim,soyisim,borcu) values(@isim,@soyisim,@borcu)", con);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox2.Text);
            cmd.Parameters.AddWithValue("@borcu", int.Parse(textBox3.Text));
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
