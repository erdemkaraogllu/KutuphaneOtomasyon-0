﻿using Npgsql;
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
    public partial class MiniYoneticiKitap : Form
    {
        public MiniYoneticiKitap()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void MiniYoneticiKitap_Load(object sender, EventArgs e)
        {
            try
            {
                dgwTablo.DataSource = yenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        

        private void dgwTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwTablo_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show(dgwTablo.Rows[e.RowIndex].Cells[1].Value + "\nAdlı Kitabı Silmek İstiyor Musunuz ?", "Kitap Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NpgsqlCommand delete = new NpgsqlCommand("DELETE FROM kitap WHERE kitap_id=" + dgwTablo.Rows[e.RowIndex].Cells[0].Value, baglanti);
                baglanti.Open();
                delete.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap Silindi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                delete.Dispose();
                GC.Collect();
                dgwTablo.DataSource = yenile();
            }
        }

        DataTable yenile()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT kitap_id, kitap_ad, yazar, tur, yayin_evi, basim, sayfa FROM kitap", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        private void txtSayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece rakam

        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void circularPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.Red;
            circularPictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.Transparent;
            circularPictureBox1.BorderStyle = BorderStyle.None;
        }

        private void circularPictureBox2_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtKitapAd.TextLength == 0 || txtYazarAd.TextLength == 0 || cbKitapTur.TabIndex == 0 || txtYayınEvi.TextLength == 0 || txtBasim.TextLength == 0 || txtSayfa.TextLength == 0)
                {
                    MessageBox.Show("Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    baglanti.Open();
                    NpgsqlCommand komut0 = new NpgsqlCommand("SELECT * FROM kitap WHERE kitap_ad = '" + txtKitapAd.Text.ToUpper() + "'", baglanti);
                    NpgsqlDataReader dr = komut0.ExecuteReader();


                    if (dr.Read())
                    {
                        MessageBox.Show("Bu Kitap Kayıtlarda Mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();


                    }
                    else
                    {
                        /*
                        create or replace function kitap_insert(_kitap_ad character varying, _yazar character varying, _tur character varying, 
										_yayin_evi character varying, _basim character varying, _sayfa character varying)
                        returns int as 
                        $$
                        begin
	                        insert into kitap(kitap_ad, yazar, tur, yayin_evi, basim, sayfa)
	                        values(_kitap_ad, _yazar, _tur, _yayin_evi, _basim, _sayfa);
	                        if found then --Başarılı
		                        return 1;
	                        else return 0; --Hata
	                        end if;
                        end
                        $$
                        language plpgsql
                        */

                        baglanti.Close();
                        baglanti.Open();
                        NpgsqlCommand kaydet = new NpgsqlCommand("SELECT FROM kitap_insert(:_kitap_ad, :_yazar, :_tur, :_yayin_evi, :_basim, :_sayfa)", baglanti);
                        kaydet.Parameters.AddWithValue("_kitap_ad", txtKitapAd.Text.ToUpper());
                        kaydet.Parameters.AddWithValue("_yazar", txtYazarAd.Text.ToUpper());
                        kaydet.Parameters.AddWithValue("_tur", cbKitapTur.SelectedItem.ToString().ToUpper());
                        kaydet.Parameters.AddWithValue("_yayin_evi", txtYayınEvi.Text.ToUpper());
                        kaydet.Parameters.AddWithValue("_basim", txtBasim.Text.ToUpper());
                        kaydet.Parameters.AddWithValue("_sayfa", txtSayfa.Text);
                        kaydet.ExecuteNonQuery();
                        baglanti.Close();

                        txtKitapAd.Text = "";
                        txtYazarAd.Text = "";
                        txtBasim.Text = "";
                        txtYayınEvi.Text = "";
                        txtSayfa.Text = "";                    

                        MessageBox.Show("Kitap Eklendi");
                        dgwTablo.DataSource = yenile();           

                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt Hatası ! " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void circularPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor = Color.Green;
            circularPictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor = Color.Transparent;
            circularPictureBox2.BorderStyle = BorderStyle.None;
        }

        private void dgwTablo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
