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
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }
            NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");


        private void button1_Click(object sender, EventArgs e)

        { if (txtKullanıcıAdı.Text == "admin" && txtPassword.Text == "00000000")
            {
                Admin form1 = new Admin();
                form1.Show();
                this.Close();
            }
            else
            {
                bool blnfound = false;

                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("SELECT * FROM userr WHERE username= '" + txtKullanıcıAdı.Text.ToUpper() + "' and password = '" + txtPassword.Text + "'", baglanti);
                NpgsqlDataReader dr = komut1.ExecuteReader();

                if (dr.Read())
                {
                    blnfound = true;

                    YoneticiAnasayfa form6 = new YoneticiAnasayfa();
                    form6.Show();
                    this.Hide();

                    MessageBox.Show("Hoş Geldiniz. !!");

                }

                if (blnfound == false)
                {
                    MessageBox.Show(" Giriş Bİlgileriniz Hatalı Tekrar Deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dr.Close();
                baglanti.Close();
            }
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }

        private void circularPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.White;
            circularPictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.Transparent;
            circularPictureBox1.BorderStyle = BorderStyle.None;
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Close();
        }
    }
}
