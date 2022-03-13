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
    public partial class MüsteriListe : Form
    {
        public MüsteriListe()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TelefonSatisData.accdb;Persist Security Info=False;");
        DataTable tablo = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listele()
        { 
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from kullanicilar where K_Yetki='User'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void MüsteriListe_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void müsterisilbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete * from kullanicilar where K_Adi='" + dataGridView1.CurrentRow.Cells["K_Adi"].Value.ToString() + "' and K_Mail='" + dataGridView1.CurrentRow.Cells["K_Mail"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(mesajlar.hatasinir10);
            tablo.Clear();
            listele();
        }

        private void arabox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from kullanicilar where K_Adi like '" + arabox.Text + "' or K_Mail like '" + arabox.Text + "' ", baglanti);
            DataTable tablo2 = new DataTable();
            adtr.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();
        }
    }
}
