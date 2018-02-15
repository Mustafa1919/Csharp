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
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data source=C:\Users\Ted\Desktop\Müşteri Takip Çalışması\kayıtlar.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("Update kayıtlar Set borcu=@borcu where isim=@isim and soyisim=@soyisim",con);
            cmd.Parameters.AddWithValue("@isim",textBox4.Text);
            cmd.Parameters.AddWithValue("@soyisim",textBox5.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        

        
    }
}
