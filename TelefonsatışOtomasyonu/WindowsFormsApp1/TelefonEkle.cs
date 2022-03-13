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
    public partial class TelefonEkle : Form
    {
        public TelefonEkle()
        {
            InitializeComponent();
        }

        private void telefoneklebutton_Click(object sender, EventArgs e)
        {
            
            if (markabox.Text == "" || modelbox.Text == "" || serinobox.Text == "" || imeinobox.Text == "" || alisfiyatbox.Text == "" || satisfiyatbox.Text == "" || kdvbox.Text == "" || renkbox.Text == "" || islemcibox.Text == "" || isletimsistemibox.Text == "" || hafizabox.Text == "" || cozunurlukbox.Text == "")
            {
                MessageBox.Show(mesajlar.hatasinir13, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TelefonSatisData.accdb;Persist Security Info=False;");
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into telefonlar (T_Marka,T_Model,T_SeriNo,T_IMEINo,T_AlisFiyat,T_SatisFiyat,T_KDV,T_Renk,T_İslemci,T_İsletimSistemi,T_Hafiza,T_Cözünürlük) values (@Marka,@Model,@SeriNo,@imeiNo,@AlisFiyat,@SatisFiyat,@kdv,@renk,@islemci,@isletimsistemi,@hafiza,@cozunurluk)", baglanti);
                OleDbCommand komut2 = new OleDbCommand("insert into satisTelefonlar (Marka,Model,Renk,İslemci,İsletimSistemi,Hafiza,Cözünürlük,Fiyat) values (@Marka2,@Model2,@Renk2,@İslemci2,@isletimsistemi2,@Hafiza2,@Cözünürlük2,@Fiyat2)", baglanti);
                komut2.Parameters.AddWithValue("@Marka2", markabox.Text);
                komut2.Parameters.AddWithValue("@Model2", modelbox.Text);
                komut2.Parameters.AddWithValue("@Renk2", renkbox.Text);
                komut2.Parameters.AddWithValue("@İslemci2", islemcibox.Text);
                komut2.Parameters.AddWithValue("@isletimsistemi2", isletimsistemibox.Text);
                komut2.Parameters.AddWithValue("@Hafiza2", hafizabox.Text);
                komut2.Parameters.AddWithValue("@Cözünürlük2", cozunurlukbox.Text);
                komut2.Parameters.AddWithValue("@Fiyat2", satisfiyatbox.Text + " TL");
                komut2.ExecuteNonQuery();
                komut.Parameters.AddWithValue("@Marka", markabox.Text);
                komut.Parameters.AddWithValue("@Model", modelbox.Text);
                komut.Parameters.AddWithValue("@SeriNo", serinobox.Text);
                komut.Parameters.AddWithValue("@imeiNo", imeinobox.Text);
                komut.Parameters.AddWithValue("@AlisFiyat", alisfiyatbox.Text + " TL"); 
                komut.Parameters.AddWithValue("@SatisFiyat", satisfiyatbox.Text + " TL");
                komut.Parameters.AddWithValue("@kdv", kdvbox.Text);
                komut.Parameters.AddWithValue("@renk", renkbox.Text);
                komut.Parameters.AddWithValue("@islemci", islemcibox.Text);
                komut.Parameters.AddWithValue("@isletimsistemi", isletimsistemibox.Text);
                komut.Parameters.AddWithValue("@hafiza", hafizabox.Text);
                komut.Parameters.AddWithValue("@cozunurluk", cozunurlukbox.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(mesajlar.hatasinir14);
                
                DialogResult onay = MessageBox.Show(mesajlar.hatasinir15, "", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes) { markabox.Text = ""; modelbox.Text = ""; serinobox.Text = ""; imeinobox.Text = ""; alisfiyatbox.Text = ""; satisfiyatbox.Text = ""; kdvbox.Text = ""; renkbox.Text = ""; islemcibox.Text = ""; isletimsistemibox.Text = ""; hafizabox.Text = ""; cozunurlukbox.Text = ""; }
            }
        }

        private void sıfırlabutton_Click(object sender, EventArgs e)
        {
            markabox.Text = ""; modelbox.Text = ""; serinobox.Text = ""; imeinobox.Text = ""; alisfiyatbox.Text = ""; satisfiyatbox.Text = ""; kdvbox.Text = ""; renkbox.Text = ""; islemcibox.Text = ""; isletimsistemibox.Text = ""; hafizabox.Text = ""; cozunurlukbox.Text = "";
        }

        private void kdvhesaplabutton_Click(object sender, EventArgs e)
        {
            KdvHesapla ac = new KdvHesapla();
            ac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
