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
    public partial class frm_sorgula : Form
    {
        public frm_sorgula()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data source=C:\Users\TED\Desktop\Müşteri Takip Programı\KayıtlarVT.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("Select Borc from Borç Where Ad=@ad and Soyad=@sad", con);
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@sad", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr["Borc"].ToString();
            }
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
        }

        
    }
}
