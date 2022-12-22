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
            try
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM kitap WHERE kitap_ad like '" + txtAra.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "kutuphane");
                dgvData.DataSource = ds.Tables["kutuphane"];
                baglanti.Close();
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama Hatası" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string deger1 = UyeGiris.deger;
            string degerAd = UyeGiris.ad;
            string degerSoyad = UyeGiris.soyad;

            label1.Text = degerAd + " " + degerSoyad;
            dgvDataOdunc.DataSource = yenileEmanet();
            dgvData.DataSource = yenileKitap();
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                txtAra.Clear();
                string sorgu = "select kitap_ad, yazar, tur, yayin_evi, basim, sayfa from kitap";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu , baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvData.DataSource = ds.Tables[0];
                

            }
            catch (Exception ex) 
            {

                MessageBox.Show("Listeleme Hatası"+ ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UyeGuncelleme form1 = new UyeGuncelleme();
            form1.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            try
            {
                //for (int i = 0; i < dgvData.SelectedRows.Count; i++)
                //{
                   baglanti.Open();
               string TC = UyeGiris.deger;
               string KitapAd = dgvData.CurrentRow.Cells[0].Value.ToString();

                

                    NpgsqlCommand komut = new NpgsqlCommand("SELECT FROM emanet_al(:_tc, :_kitap_ad)", baglanti);
                    komut.Parameters.AddWithValue("_tc", TC);
                    komut.Parameters.AddWithValue("_kitap_ad",KitapAd);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kitap Emanet Alındı !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvData.DataSource = yenileKitap();
                    dgvDataOdunc.DataSource = yenileEmanet(); 

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Emanet Alma Hatası !", "HATA " +  ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        DataTable yenileKitap()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT kitap_ad, yazar, tur, yayin_evi, basim, sayfa FROM kitap", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        DataTable yenileEmanet()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT kitap_ad FROM emanet_kitap", baglanti);
            DataTable tablo1 = new DataTable();
            da.Fill(tablo1);
            baglanti.Close();
            return tablo1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string deger1 = UyeGiris.deger;
            label3.Text = deger1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {

        }

        
    }
}
