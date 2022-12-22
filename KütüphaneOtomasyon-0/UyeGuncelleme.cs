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
    public partial class UyeGuncelleme : Form
    {
        public UyeGuncelleme()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeAnasayfa form1 = new UyeAnasayfa();
            form1.Show();
            this.Hide();

        }

        private void UyeGuncelleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool blnfound = false;
                baglanti.Open();

                NpgsqlCommand komut2 = new NpgsqlCommand("Select * from uyebilgi where tc = '" + txtTC.Text + "' and uye_ad = '" + txtAd.Text +"'", baglanti);
                NpgsqlDataReader dr = komut2.ExecuteReader();
                if (dr.Read())
                {
                    blnfound = true;

                    DialogResult karar = MessageBox.Show("Değişiklikleri Onaylıyor Musunuz ?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    baglanti.Close();
                    if (karar== DialogResult.Yes)
                    {
                        baglanti.Open();
                    NpgsqlCommand komut1 = new NpgsqlCommand("select * from st_update(:_tc, :_uye_ad, :_uye_soyad, :_uye_telefon, :_uye_sifre)", baglanti);
                    komut1.Parameters.AddWithValue("_tc", txtTC.Text);
                    komut1.Parameters.AddWithValue("_uye_ad", txtAd.Text);
                    komut1.Parameters.AddWithValue("_uye_soyad", txtSoyad.Text);
                    komut1.Parameters.AddWithValue("_uye_telefon", txtTelefon.Text);
                    komut1.Parameters.AddWithValue("_uye_sifre", txtSifre.Text);
                    komut1.ExecuteNonQuery(); 
                        baglanti.Close();
                        MessageBox.Show("Bilgileriniz Güncellendi. !!");
                    }
                    
                }

                if (blnfound == false)
                {
                    MessageBox.Show("Bilgileriniz Hatalı Lütfen Tekrar Giriniz. !!", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    foreach (Control item in this.Controls)
                    {
                        if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
                    }
                }
                dr.Close();
                             
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt Hatası ! " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);

            }
        }
    }
}
