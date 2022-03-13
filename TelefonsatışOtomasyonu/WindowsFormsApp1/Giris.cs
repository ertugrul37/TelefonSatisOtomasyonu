using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();         
            sifretextbox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kayitol_Click(object sender, EventArgs e)
        {
            this.Close();
            Kayit ac = new Kayit();
            ac.Show();
        }
        public static string girisKisi;
        int hataSinir = 0;

        private void girisyap_Click(object sender, EventArgs e)
        {
            
            if (hataSinir == 5)
            {
                MessageBox.Show(mesajlar.hatasinir1);
                Application.Exit();
            }
            else
            {
                if (kullaniciaditextbox.Text == "" || sifretextbox.Text == "")
                {
                    hataSinir++;
                    label2.Text = mesajlar.hatasinir2 + (5 - hataSinir);
                }
                else
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TelefonSatisData.accdb;Persist Security Info=False;");
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("Select * From kullanicilar where K_Adi='" + kullaniciaditextbox.Text + "' and K_Sifre='" + sifretextbox.Text + "'", baglanti);
                    OleDbDataReader okuyucu = komut.ExecuteReader();

                    while (okuyucu.Read())
                    {
                        if (kullaniciaditextbox.Text.ToString() == okuyucu["K_Adi"].ToString() && sifretextbox.Text.ToString() == okuyucu["K_Sifre"].ToString())
                        {
                            if (okuyucu["K_Yetki"].ToString() == "Developer" || okuyucu["K_Yetki"].ToString() == "Admin")
                            {
                                girisKisi = kullaniciaditextbox.Text; 
                                this.Hide();
                                YoneticiGenelPanel ac = new YoneticiGenelPanel();
                                ac.Show();
                            }
                            
                            else if (okuyucu["K_Yetki"].ToString() == "User")
                            {
                                this.Hide();
                                UserMenu ac = new UserMenu();
                                ac.Show();
                            }
                            break;
                        }
                    }
                    
                    hataSinir++;
                    label2.Text = mesajlar.hatasinir2 + (5 - hataSinir);
                    baglanti.Close();
                }
            }
        }       
    }
}
