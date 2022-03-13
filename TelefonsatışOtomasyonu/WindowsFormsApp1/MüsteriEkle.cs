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
    public partial class MüsteriEkle : Form
    {
        public MüsteriEkle()
        {
            InitializeComponent();
        }
        private void kapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void hesapolustur_Click(object sender, EventArgs e)
        {
            
            if (adbox.Text == "" || sifrebox.Text == "" || mailbox.Text == "" || numaratextbox.Text == "" || adsoyadbox.Text == "")
            {
                MessageBox.Show(mesajlar.hatasinir7, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (adbox.Text == "") adbox.Text =mesajlar.hatasinir8 ;
                else if (sifrebox.Text == "") sifrebox.Text =mesajlar.hatasinir8;
                else if (mailbox.Text == "") mailbox.Text =mesajlar.hatasinir8;
                else if (numaratextbox.Text == "") numaratextbox.Text = mesajlar.hatasinir8;

                 
            }
            else
            {
                
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TelefonSatisData.accdb;Persist Security Info=False;");
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into kullanicilar (K_Adi,K_Sifre,K_AdSoyad,K_Mail,K_Numara,K_Yetki) values (@KullaniciAdi,@Sifre,@AdSoyad,@Mail,@Numara,@Yetki)", baglanti);
                komut.Parameters.AddWithValue("@KullaniciAdi", adbox.Text);
                komut.Parameters.AddWithValue("@Sifre", sifrebox.Text);
                komut.Parameters.AddWithValue("@AdSoyad", adsoyadbox.Text);
                komut.Parameters.AddWithValue("@Mail", mailbox.Text);
                komut.Parameters.AddWithValue("@Numara", numaratextbox.Text);
                komut.Parameters.AddWithValue("@Yetki", "User");
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(mesajlar.hatasinir9);
                sifrebox.Text = ""; mailbox.Text = ""; adbox.Text = ""; numaratextbox.Text = ""; adsoyadbox.Text = "";
            }
        }

        private void gizlegoster_CheckedChanged(object sender, EventArgs e)
        {
            if (gizlegoster.CheckState == CheckState.Unchecked)
            {
                sifrebox.UseSystemPasswordChar = true;
                gizlegoster.Text = "Göster";
            }
            else if (gizlegoster.CheckState == CheckState.Checked)
            {
                sifrebox.UseSystemPasswordChar = false;
                gizlegoster.Text = "Gizle";
            }
        }
    }
}

