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


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            bool blnfound = false;

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("Select * from userr where username= '" + txtKullanıcıAdı.Text + "' and password = '" + txtPassword.Text + "'", baglanti);
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
                MessageBox.Show("Tekrar Deneyin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dr.Close();
            baglanti.Close();



            
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
