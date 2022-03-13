using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class YoneticiGenelPanel : Form
    {
        public YoneticiGenelPanel()
        {
            InitializeComponent();
        }

        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MüsteriEkle ac = new MüsteriEkle();
            ac.MdiParent = this;
            ac.Show();
        }

        private void musteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MüsteriListe ac = new MüsteriListe();
            ac.MdiParent = this;
            ac.Show();
        }

        private void satısListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisListe ac = new SatisListe();
            ac.MdiParent = this;
            ac.Show();
        }

        private void satısYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisYap ac = new SatisYap();
            ac.MdiParent = this;
            ac.Show();
        }

        private void telefonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonEkle ac = new TelefonEkle();
            ac.MdiParent = this;
            ac.Show();
        }

        private void telefonListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonListe ac = new TelefonListe();
            ac.MdiParent = this;
            ac.Show();
        }

        private void yöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiEkle ac = new YoneticiEkle();
            ac.MdiParent = this;
            ac.Show();
        }

        private void yöneticiListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiListe ac = new YoneticiListe();
            ac.MdiParent = this;
            ac.Show();
        }

        private void hakkındaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hakkında ac = new Hakkında();
            ac.Show();
        }

        
    }
}
