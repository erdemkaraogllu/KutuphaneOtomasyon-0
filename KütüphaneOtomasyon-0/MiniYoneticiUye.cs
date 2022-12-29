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
using System.Xml.Linq;

namespace KütüphaneOtomasyon_0
{
    public partial class MiniYoneticiUye : Form
    {
        public MiniYoneticiUye()
        {
            InitializeComponent();
        }
            NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");
 
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void MiniYoneticiUye_Load(object sender, EventArgs e)
        {
            dgvKitap.DataSource = yenileEmanet();
            try
              {
                 string sorgu = "SELECT tc, uye_ad, uye_soyad, uye_telefon FROM uyebilgi";
                 NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                 DataSet ds = new DataSet();
                 da.Fill(ds);
                 dgvUye.DataSource = ds.Tables[0];

              }
              catch(Exception ex)
              {
                 MessageBox.Show("Listeleme Hatası" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
              }
            

            
        }

        DataTable yenileUye()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT tc, uye_ad, uye_soyad, uye_telefon FROM uyebilgi",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        
        DataTable yenileEmanet()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT emanet_id, tc, kitap_ad, emanet_date, teslim_date FROM emanet_kitap", baglanti);
            DataTable tablo1 = new DataTable();
            da.Fill(tablo1);
            baglanti.Close();
            return tablo1;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece rakam
        }

        private void txtEmanetAra_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void circularPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.Transparent;
        }

        private void dgvKitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void circularPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor = Color.Red;
            circularPictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor = Color.Transparent;
            circularPictureBox2.BorderStyle = BorderStyle.None;
        }

        private void circularPictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvUye.SelectedRows.Count; i++)
                {
                    baglanti.Open();
                    NpgsqlCommand komut = new NpgsqlCommand("DELETE FROM uyebilgi WHERE tc = '" + dgvUye.SelectedRows[i].Cells[0].Value + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Üye Silindi !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvUye.DataSource = yenileUye();

                }
                //MessageBox.Show("Silmek İstediğiniz Üyeyi Seçiniz !","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Silinemedi", "HATA " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void circularPictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM uyebilgi WHERE tc like '" + txtAra.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "uyebilgi");
                dgvUye.DataSource = ds.Tables["uyebilgi"];
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama Hatası" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void circularPictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu0 = "SELECT * FROM emanet_kitap WHERE tc like '" + txtEmanetAra.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu0, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "emanetkitap");
                dgvKitap.DataSource = ds.Tables["emanetkitap"];
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama Hatası" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void circularPictureBox3_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox3.BackColor = Color.Yellow;
            circularPictureBox3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox3_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox3.BackColor = Color.Transparent;
            circularPictureBox3.BorderStyle = BorderStyle.None;
        }

        private void circularPictureBox4_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox4.BackColor = Color.Yellow;
            circularPictureBox4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox4_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox4.BackColor = Color.Transparent;
            circularPictureBox4.BorderStyle = BorderStyle.None;
        }

        private void circularPictureBox5_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox5.BackColor = Color.Green;
            circularPictureBox5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox5_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox5.BackColor = Color.Transparent;
            circularPictureBox5.BorderStyle = BorderStyle.None;
        }

        private void circularPictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvKitap.SelectedRows.Count; i++)
                {
                    string id = dgvKitap.SelectedRows[i].Cells[0].Value.ToString();
                    string tc = dgvKitap.SelectedRows[i].Cells[1].Value.ToString();
                    string kitapAd = dgvKitap.SelectedRows[i].Cells[2].Value.ToString();
                    baglanti.Open();
                    NpgsqlCommand komut = new NpgsqlCommand("DELETE FROM emanet_kitap WHERE emanet_id = '" + id + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Emanet Kitap Teslim Alındı !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvKitap.DataSource = yenileEmanet();

                    /*
                     
                    */

                    baglanti.Open();
                    NpgsqlCommand komut1 = new NpgsqlCommand("SELECT FROM kitap_okundu(:_tc, :_kitap_ad)", baglanti);
                    komut1.Parameters.AddWithValue("_tc", tc);
                    komut1.Parameters.AddWithValue("_kitap_ad", kitapAd);
                    komut1.ExecuteNonQuery();
                    baglanti.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap Teslim Edilemedi !", "HATA " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }
    }
}
