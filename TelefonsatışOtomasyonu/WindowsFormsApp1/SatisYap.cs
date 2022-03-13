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
    public partial class SatisYap : Form
    {
        public SatisYap()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TelefonSatisData.accdb;Persist Security Info=False;");
        DataTable tablo = new DataTable();

        private void listele()
        {
           
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from telefonlar", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void satisyapbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete * from telefonlar where T_Marka='" + dataGridView1.CurrentRow.Cells["T_Marka"].Value.ToString() + "' and T_ID=" + dataGridView1.CurrentRow.Cells["T_ID"].Value.ToString() + "", baglanti);
            komut.ExecuteNonQuery();
           
            MessageBox.Show(mesajlar.hatasinir12 + msg("T_Marka") + "\n Model = " + msg("T_Model") + "\n Alış Fiyat = " + msg("T_AlisFiyat") + "\n Satış Fiyat = " + msg("T_SatisFiyat") + "\n KDV = " + msg("T_KDV") + " ");


            OleDbCommand qw = new OleDbCommand("insert into satilanTelefonlar (S_Marka,S_Model,S_AlisFiyat,S_SatisFiyat,S_KDV) values (@Marka,@Model,@Alis,@Satis,@kdv)", baglanti);
            qw.Parameters.AddWithValue("@Marka", msg("T_Marka"));
            qw.Parameters.AddWithValue("@Model", msg("T_Marka"));
            qw.Parameters.AddWithValue("@Alis", msg("T_AlisFiyat"));
            qw.Parameters.AddWithValue("@Satis", msg("T_SatisFiyat"));
            qw.Parameters.AddWithValue("@kdv", msg("T_KDV"));
            qw.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            listele();
        }

        private void arabox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from telefonlar where T_Marka like '" + arabox.Text + "' or T_SeriNo like '" + arabox.Text + "' ", baglanti);
            DataTable tablo2 = new DataTable();
            adtr.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();
        }
        private void SatisYap_Load(object sender, EventArgs e)
        {
            listele();
        }
        private string msg(string msg)
        {          
            return dataGridView1.CurrentRow.Cells[msg].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
