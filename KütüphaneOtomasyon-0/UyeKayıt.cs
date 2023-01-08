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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                if (txtTC.TextLength == 0 || txtAd.TextLength == 00 || txtSoyad.TextLength == 0 || txtTelefon.TextLength == 0 || txtSifre.TextLength == 0)
                {
                    MessageBox.Show("Boş Alan Bırakmayınız !");
                }
                else
                {
                    if (Dogrula(txtTC.Text) == false)
                    {
                        MessageBox.Show("Lütfen Geçerli Bir TC Kimlik Numarası Giriniz !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Dogrula(txtTC.Text) == true)
                    {

                        bool sorgu = false;
                        baglanti.Open();
                        NpgsqlCommand komut0 = new NpgsqlCommand("SELECT FROM uyebilgi WHERE tc = '" + txtTC.Text + "'", baglanti);
                        NpgsqlDataReader dr = komut0.ExecuteReader();
                        if (dr.Read())
                        {
                            sorgu = true;
                            MessageBox.Show("Sistemde Zaten Kayıtlısınız !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            baglanti.Close();
                            dr.Close();
                        }

                        if (sorgu == false)
                        {
                            if (6 <= txtSifre.TextLength && txtSifre.TextLength <= 8)
                            {
                                baglanti.Close();
                                baglanti.Open();
                                NpgsqlCommand komut1 = new NpgsqlCommand("Select from uye_insert(:_tc, :_uye_ad, :_uye_soyad, :_uye_telefon, :_uye_sifre)", baglanti);
                                komut1.Parameters.AddWithValue("_tc", txtTC.Text);
                                komut1.Parameters.AddWithValue("_uye_ad", txtAd.Text.ToUpper());
                                komut1.Parameters.AddWithValue("_uye_soyad", txtSoyad.Text.ToUpper());
                                komut1.Parameters.AddWithValue("_uye_telefon", txtTelefon.Text);
                                komut1.Parameters.AddWithValue("_uye_sifre", txtSifre.Text);
                                komut1.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("Kayıt Başarılı.");

                                Anasayfa form2 = new Anasayfa();
                                form2.Show();
                                this.Hide();

                                /*
                                create or replace function uye_insert(_tc character varying, _uye_ad character varying, _uye_soyad character varying,
                                              _uye_telefon character varying, _uye_sifre character varying)
                                returns int as 
                                $$
                                begin
                                    insert into uye_bilgi(tc, uye_ad, uye_soyad, uye_telefon, uye_sifre)
                                    values(_tc, _uye_ad, _uye_soyad, _uye_telefon, _uye_sifre);
                                    if found then --Başarılı
                                        return 1;
                                    else return 0; --Hata
                                    end if;
                                end
                                $$
                                language plpgsql
                                */
                            }
                            else
                            {
                                baglanti.Close();
                                MessageBox.Show("Lütfen En Az 6 En Fazla 8 Karakterli Bir Şifre Oluşturunuz !");
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt Hatası ! " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }

        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {           
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }        
        }
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece rakam
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool Dogrula(string tcNo)
        {
            int[] tc = new int[11];
            for (int i = 0; i < 11; i++)
            {
                tc.SetValue(Convert.ToInt16(tcNo.Substring(i, 1)), i);
            }
            int tek = (tc[0] + tc[2] + tc[4] + tc[6] + tc[8]) * 7;
            int cift = tc[1] + tc[3] + tc[5] + tc[7];
            int sonuc = tek - cift;
            int onbir = (tc[0] + tc[2] + tc[4] + tc[6] + tc[8]) * 8;
            string sonBasamak = onbir.ToString().Substring(onbir.ToString().Length - 1, 1);
            if (tc[0] == 0)
            {
                return false;
            }
            else if (sonuc.ToString().Substring(sonuc.ToString().Length - 1, 1) != tc[9].ToString())
            {
                return false;
            }
            else if (sonBasamak != tc[10].ToString())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
