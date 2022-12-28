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
    public partial class SifreUnuttum : Form
    {
        public SifreUnuttum()
        {
            InitializeComponent();
        }
            NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu");   
        private void circularPictureBox2_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void circularPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor = Color.Red;
        }

        private void circularPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor = Color.Transparent;
        }

        private void circularPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.Green;
        }

        private void circularPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.Transparent;
        }

        private void SifreUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {   
            bool sorgu = false;
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM uyebilgi WHERE tc = '"+ txtTC.Text +"' and uye_telefon = '"+ txtTelefon.Text +"'", baglanti);
            NpgsqlDataReader dr = komut.ExecuteReader();
            

            if (dr.Read())
            {
                sorgu = true;
                dr.Close();
                baglanti.Close();
            }

                if (sorgu == true)
                {                
                    baglanti.Open();
                    NpgsqlCommand komut1 = new NpgsqlCommand("UPDATE uyebilgi SET uye_sifre = '" + txtŞifre.Text + "' WHERE tc = '" + txtTC.Text + "' ", baglanti);
                    komut1.ExecuteNonQuery();
                    baglanti.Close();


                    MessageBox.Show("Şifre Güncellendi! Yeni Şifreniz İle Giriş Yapabilirsiniz!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActiveForm.Close();
                }
                else if(sorgu == false)
                {
                    MessageBox.Show("Bilgileriniz Yanlış!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    foreach (Control item in this.Controls)
                    {
                        if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
                    }
                }
            baglanti.Close();
        }
    }
}
