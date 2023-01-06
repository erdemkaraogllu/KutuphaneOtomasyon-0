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
     

        private void SifreUnuttum_Load(object sender, EventArgs e)
        {

        }       

        private void circularPictureBox3_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void circularPictureBox3_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox3.BackColor= Color.White;
            circularPictureBox3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox3_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox3.BackColor = Color.Transparent;
            circularPictureBox3.BorderStyle = BorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sorgu = false;
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM uyebilgi WHERE tc = '" + txtTC.Text + "' AND uye_telefon = '" + txtTelefon.Text + "'", baglanti);
            NpgsqlDataReader dr = komut.ExecuteReader();


            if (dr.Read())
            {
                sorgu = true;
                dr.Close();
                baglanti.Close();
            }

            if (sorgu == true)
            {
                if (txtŞifre.TextLength <6 && txtŞifre.TextLength <=8) 
                {

                }
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("UPDATE uyebilgi SET uye_sifre = '" + txtŞifre.Text + "' WHERE tc = '" + txtTC.Text + "' ", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();


                MessageBox.Show("Şifre Güncellendi! Yeni Şifreniz İle Giriş Yapabilirsiniz!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveForm.Close();
            }
            else if (sorgu == false)
            {
                MessageBox.Show("Bilgileriniz Yanlış!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                foreach (Control item in this.Controls)
                {
                    if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
                }
            }
            baglanti.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtŞifre.UseSystemPasswordChar = true;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtŞifre.UseSystemPasswordChar = false;
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece rakam
        }
    }
}
