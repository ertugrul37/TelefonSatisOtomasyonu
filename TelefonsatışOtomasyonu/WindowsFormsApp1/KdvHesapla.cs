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
    public partial class KdvHesapla : Form
    {
        public KdvHesapla()
        {
            InitializeComponent();
            kdvtutaribox.Text = "0.00 TL";
            kdvdahiltutaribox.Text = "0.00 TL";
            adetbox.Text = "1";
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double fiyat, adet = 1, toplam, kdv;
            if (tutarbox.Text == "" || adetbox.Text == "") MessageBox.Show(mesajlar.hatasinir5);
            else
            {
                if (yuzdebir.Checked || yuzdesekiz.Checked || yuzdeonsekiz.Checked)
                {
                    fiyat = double.Parse(tutarbox.Text);
                    adet = double.Parse(adetbox.Text);
                    toplam = fiyat * adet;
                    kdv = 0;
                    if (yuzdebir.Checked) kdv = toplam * 0.01;
                    else if (yuzdesekiz.Checked) kdv = toplam * 0.08;
                    else if (yuzdeonsekiz.Checked) kdv = toplam * 0.18;

                    kdvtutaribox.Text = kdv + " TL";
                    kdvdahiltutaribox.Text = (kdv + toplam) + " TL";
                }
                else MessageBox.Show(mesajlar.hatasinir6);
            }
        }
    }
}
