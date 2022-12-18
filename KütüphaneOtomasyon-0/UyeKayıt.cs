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
    public partial class UyeKayıt : Form
    {
        public UyeKayıt()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("Select from uye_insert(:_tc, :_uye_ad, :_uye_soyad, :_uye_telefon, :_uye_sifre)", baglanti);
                komut1.Parameters.AddWithValue("_tc", txtTC.Text);
                komut1.Parameters.AddWithValue("_uye_ad", txtAd.Text);
                komut1.Parameters.AddWithValue("_uye_soyad", txtSoyad.Text);
                komut1.Parameters.AddWithValue("_uye_telefon", txtTelefon.Text);
                komut1.Parameters.AddWithValue("_uye_sifre", txtSifre.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt Başarılı.");
            }
            catch(Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt Hatası ! " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);

            }
            UyeGiris form2 = new UyeGiris();
            form2.Show();
            this.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeGiris form2 = new UyeGiris();
            form2.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
