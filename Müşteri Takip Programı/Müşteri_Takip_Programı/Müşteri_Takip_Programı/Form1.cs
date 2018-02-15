using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Müşteri_Takip_Programı
{
    public partial class frm_anasayfa : Form
    {
        public frm_anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_yenikayit yk = new frm_yenikayit();
            yk.ShowDialog();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yenikayit yk = new frm_yenikayit();
            yk.ShowDialog();
        }

        private void borçEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_borc borc = new frm_borc();
            borc.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_borc borc = new frm_borc();
            borc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_satis sat = new frm_satis();
            sat.ShowDialog();
        }

        private void borçSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_satis sat = new frm_satis();
            sat.ShowDialog();
        }

        private void stokDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sorgula sor = new frm_sorgula();
            sor.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_sorgula sor = new frm_sorgula();
            sor.ShowDialog();
        }

        private void satışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_stok stok = new frm_stok();
            stok.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_stok stok = new frm_stok();
            stok.ShowDialog();
        }

        

        

       
    }
}
