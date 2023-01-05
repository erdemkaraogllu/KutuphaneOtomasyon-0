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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   if (txtAd.TextLength == 0 || txtSifre.TextLength == 0)
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız","UYARI",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtSifre.TextLength < 8)
                    {
                        MessageBox.Show("Şifrenizi Lütfen 8 haneli Giriniz !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        /* 
                        create or replace function emanet_al(_tc character varying, _kitap_ad character varying)
                        returns int as 
                        $$
                        begin
	                        insert into emanet_kitap(tc,kitap_ad)
	                        values(_tc,_kitap_ad);
	                        if found then --Başarılı
		                        return 1;
	                        else return 0; --Hata
	                        end if;
                        end
                        $$
                        language plpgsql
                        */

                        baglanti.Open();
                        NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM yönetici_ekle(:_username, :_password)", baglanti);
                        komut.Parameters.AddWithValue("_username", txtAd.Text.ToUpper());
                        komut.Parameters.AddWithValue("_password", txtSifre.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Yeni Yönetici Eklendi !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Bağlantı Hatası","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoneticiGiris form1 = new YoneticiGiris();
            form1.Show();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dgvYönetici.DataSource = Yenile();
        }
        DataTable Yenile()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT id,username,password FROM userr", baglanti);
            DataTable Tablo = new DataTable();
            da.Fill(Tablo);
            baglanti.Close();
            return Tablo;
        }

        private void dgvYönetici_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (MessageBox.Show(dgvYönetici.Rows[e.RowIndex].Cells[1].Value + "\nAdlı Yöneticiyi Silmek İstiyor Musunuz ?", "Yönetici Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NpgsqlCommand delete = new NpgsqlCommand("DELETE FROM userr WHERE id=" + dgvYönetici.Rows[e.RowIndex].Cells[0].Value, baglanti);
                    baglanti.Open();
                    delete.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Yönetici Silindi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    delete.Dispose();
                    GC.Collect();
                    dgvYönetici.DataSource = Yenile();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Hata " + ex);
            }
        }
    }
}
