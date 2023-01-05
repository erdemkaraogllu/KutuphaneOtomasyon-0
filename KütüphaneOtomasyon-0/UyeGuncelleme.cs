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
            this.Close();
        }

        private void UyeGuncelleme_Load(object sender, EventArgs e)
        {
            string deger0 = UyeGiris.deger;
            string deger1 = UyeGiris.ad;
            string deger2 = UyeGiris.soyad;
            txtTC.Text = deger0;
            txtAd.Text = deger1;
            txtSoyad.Text = deger2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {               

                if (txtAd.TextLength == 0 || txtSoyad.TextLength == 0 || txtSifre.TextLength == 0 || txtTC.TextLength == 0 || txtTelefon.TextLength == 0)
                {
                    MessageBox.Show("Lütfen Bilgilerinizi Güncellerken Boş Alan Bırakmayınız !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (6 <= txtSifre.TextLength && txtSifre.TextLength <= 8)
                    {

                        bool sorgu = false;
                        baglanti.Open();

                        NpgsqlCommand komut2 = new NpgsqlCommand("Select * from uyebilgi where tc = '" + txtTC.Text + "' and uye_telefon = '" + txtTelefon.Text + "'", baglanti);
                        NpgsqlDataReader dr = komut2.ExecuteReader();

                        if (dr.Read())
                        {
                            sorgu = true;

                            DialogResult karar = MessageBox.Show("Değişiklikleri Onaylıyor Musunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            baglanti.Close();
                            if (karar == DialogResult.Yes)
                            {
                                /* 
                                create or replace function st_update(_tc character varying, _uye_ad character varying, _uye_soyad character varying,
                                         _uye_telefon character varying, _uye_sifre character varying)
                                returns int as
                                $$
                                begin
                                    update uyebilgi
                                    set	
                                        uye_ad = _uye_ad,
                                        uye_soyad = _uye_soyad,
                                        uye_telefon = _uye_telefon,
                                        uye_sifre = _uye_sifre
                                    where tc = _tc;
                                    if found then 
                                        return 1;
                                    else 
                                        return 0;
                                    end if;
                                end
                                $$
                                language plpgsql
                                */
                                baglanti.Open();
                                NpgsqlCommand komut1 = new NpgsqlCommand("select * from st_update(:_tc, :_uye_ad, :_uye_soyad, :_uye_telefon, :_uye_sifre)", baglanti);
                                komut1.Parameters.AddWithValue("_tc", txtTC.Text);
                                komut1.Parameters.AddWithValue("_uye_ad", txtAd.Text.ToUpper());
                                komut1.Parameters.AddWithValue("_uye_soyad", txtSoyad.Text.ToUpper());
                                komut1.Parameters.AddWithValue("_uye_telefon", txtTelefon.Text);
                                komut1.Parameters.AddWithValue("_uye_sifre", txtSifre.Text);
                                komut1.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Bilgileriniz Güncellendi. !!");
                            }
                        }

                        if (sorgu == false)
                        {
                            MessageBox.Show("Bilgileriniz Hatalı Lütfen Tekrar Giriniz. !!", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            foreach (Control item in this.Controls)
                            {
                                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
                            }
                        }
                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen En Az 6 En Fazla 8 Karakterli Bir Şifre Oluşturunuz !");
                    }
                }                
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt Hatası ! " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece rakam
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
