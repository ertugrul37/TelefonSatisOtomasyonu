using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
            sifreolusturtextbox.UseSystemPasswordChar = true;
        }
        int hataSinir = 0;
        private void kayitol_Click(object sender, EventArgs e)
        {
            
            if (hataSinir == 5)
            {
                MessageBox.Show(mesajlar.hatasinir1);
                Application.Exit();
            }
            else
            {
                
                if (kullaniciadiolusturtextbox.Text == "" || sifreolusturtextbox.Text == "" || mailolusturtextbox.Text == "" || numaraolusturtextbox.Text == "" || adsoyadolusturbox.Text == "")
                {
                    hataSinir++;
                    lblbilgikayıt.Text = mesajlar.hatasinir2 + (5 - hataSinir);
                }
                else
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TelefonSatisData.accdb;Persist Security Info=False;");
                    baglanti.Open();
                    OleDbCommand hesapVarMi = new OleDbCommand("Select * From kullanicilar where K_Adi='" + kullaniciadiolusturtextbox.Text + "'", baglanti);
                    OleDbDataReader okuyucu = hesapVarMi.ExecuteReader();
                    bool izin = true;
                    while (okuyucu.Read())
                    {
                        if (kullaniciadiolusturtextbox.Text.ToString() == okuyucu["K_Adi"].ToString())
                        {
                            
                            hataSinir++;
                            lblbilgikayıt.Text = mesajlar.hatasinir3 + (5 - hataSinir);
                            izin = false;
                        }
                    }
                    if (izin == true) 
                    {
                        
                        OleDbCommand komut = new OleDbCommand("insert into kullanicilar (K_Adi,K_Sifre,K_AdSoyad,K_Mail,K_Numara,K_Yetki) values (@KullaniciAdi,@Sifre,@AdSoyad,@Mail,@Numara,@Yetki)", baglanti);
                        komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciadiolusturtextbox.Text);
                        komut.Parameters.AddWithValue("@Sifre", sifreolusturtextbox.Text);
                        komut.Parameters.AddWithValue("@AdSoyad", adsoyadolusturbox.Text);
                        komut.Parameters.AddWithValue("@Mail", mailolusturtextbox.Text);
                        komut.Parameters.AddWithValue("@Numara", numaraolusturtextbox.Text);
                        komut.Parameters.AddWithValue("@Yetki", "User");
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show(mesajlar.hatasinir4);
                        this.Close();
                        Giris ac = new Giris();
                        ac.Show();
                    }
                    else
                    {                      
                        kullaniciadiolusturtextbox.Text = ""; mailolusturtextbox.Text = ""; sifreolusturtextbox.Text = ""; numaraolusturtextbox.Text = ""; adsoyadolusturbox.Text = "";
                    }
                }
            }
        }

    }
}
