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
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pbKayıtSil.BackColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pbKayıtSil.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pbOduncVer.BackColor = Color.Green;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pbOduncVer.BackColor= Color.Transparent;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pbAra.BackColor = Color.Orange;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pbAra.BackColor = Color.Transparent;
        }

        private void MiniYoneticiUye_Load(object sender, EventArgs e)
        {
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

        private void pbAra_Click(object sender, EventArgs e)
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

        private void pbKayıtSil_Click(object sender, EventArgs e)
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
            catch(Exception ex )
            {
                MessageBox.Show("Kullanıcı Silinemedi","HATA " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
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
        
    }
}
