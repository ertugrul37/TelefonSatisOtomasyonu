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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TelefonSatisData.accdb;Persist Security Info=False;");
        DataTable tablo = new DataTable();
        private void listele()
        {
            
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from satisTelefonlar", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UserMenu_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void arabox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from satisTelefonlar where Marka like '" + arabox.Text + "' or Model like '" + arabox.Text + "' ", baglanti);
            DataTable tablo2 = new DataTable();
            adtr.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();
        }
    }
}
