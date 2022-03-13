using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class YoneticiEkle : Form
    {
        public YoneticiEkle()
        {
            InitializeComponent();
            gizlegoster.CheckState = CheckState.Unchecked;
            yoneticisifre.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yoneticihesapac_Click(object sender, EventArgs e)
        {
           
            if (yoneticiadibox.Text == "" || yoneticisifre.Text == "" || yoneticimail.Text == "" || numarabox.Text == "" || adsoyadbox.Text == "")
            {
                MessageBox.Show(mesajlar.hatasinir7, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (yoneticiadibox.Text == "") yoneticiadibox.Text = mesajlar.hatasinir8;
                else if (yoneticisifre.Text == "") yoneticisifre.Text = mesajlar.hatasinir8;
                else if (yoneticimail.Text == "") yoneticimail.Text = mesajlar.hatasinir8;
                else if (numarabox.Text == "") numarabox.Text = mesajlar.hatasinir8;
            }
            else
            {
               
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TelefonSatisData.accdb;Persist Security Info=False;");
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into kullanicilar (K_Adi,K_Sifre,K_AdSoyad,K_Mail,K_Numara,K_Yetki) values (@KullaniciAdi,@Sifre,@AdSoyad,@Mail,@Numara,@Yetki)", baglanti);
                komut.Parameters.AddWithValue("@KullaniciAdi", yoneticiadibox.Text);
                komut.Parameters.AddWithValue("@Sifre", yoneticisifre.Text);
                komut.Parameters.AddWithValue("@AdSoyad", adsoyadbox.Text);
                komut.Parameters.AddWithValue("@Mail", yoneticimail.Text);
                komut.Parameters.AddWithValue("@Numara", numarabox.Text);
                komut.Parameters.AddWithValue("@Yetki", "Admin");
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(mesajlar.hatasinir16);
                yoneticisifre.Text = ""; yoneticimail.Text = ""; yoneticiadibox.Text = ""; numarabox.Text = ""; adsoyadbox.Text = "";
            }

        }

        private void gizlegoster_CheckedChanged(object sender, EventArgs e)
        {
            if (gizlegoster.CheckState == CheckState.Unchecked)
            {
                yoneticisifre.UseSystemPasswordChar = true;
                gizlegoster.Text = "Göster";
            }
            else if (gizlegoster.CheckState == CheckState.Checked)
            {
                yoneticisifre.UseSystemPasswordChar = false;
                gizlegoster.Text = "Gizle";
            }
        }
    }
}
