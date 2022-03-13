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
    public partial class TelefonListe : Form
    {
        public TelefonListe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void arabox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from telefonlar where T_Marka like '" + arabox.Text + "' or T_ID like " + arabox.Text + " ", baglanti);
            DataTable tablo2 = new DataTable();
            adtr.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();
        }

        private void telefonsilbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete * from telefonlar where T_ID=" + dataGridView1.CurrentRow.Cells["T_ID"].Value.ToString() + " and T_SeriNo='" + dataGridView1.CurrentRow.Cells["T_SeriNo"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(mesajlar.hatasinir11);
            tablo.Clear();
            listele();
        }
        private void TelefonListe_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
