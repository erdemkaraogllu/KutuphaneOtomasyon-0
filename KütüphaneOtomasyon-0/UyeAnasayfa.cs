using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon_0
{
    public partial class UyeAnasayfa : Form


    {
        

        public UyeAnasayfa()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");
        

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "select * from kitap";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu , baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvData.DataSource = ds.Tables[0];   

            }
            catch(Exception ex) 
            {

                MessageBox.Show("Listeleme Hatası"+ ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UyeGuncelleme form1 = new UyeGuncelleme();
            form1.Show();
            this.Hide();
        }
    }
}
