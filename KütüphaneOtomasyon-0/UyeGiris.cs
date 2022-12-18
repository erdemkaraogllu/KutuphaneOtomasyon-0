using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KütüphaneOtomasyon_0
{
    public partial class UyeGiris : Form
    {
        public UyeGiris()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");

        /*public bool Login(string kullanıcıAdi, string sifre)
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select userName, Password from userr where UserName='" + kullanıcıAdi + "' and Password='" + sifre + "'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Bilgileriniz yanlış veya böyle bir hesap mevcut değil !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dt.Rows[0][1].ToString() == "1")
            {
                MessageBox.Show("Giriş Yapıldı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            

            
        } */
            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeKayıt form4 = new UyeKayıt();
            form4.Show();
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

            /* if (Login(txtKullanıcıAdı.Text, txtPassword.Text))
             {
                 MessageBox.Show("Hoşgeldiniz");
                 UyeAnasayfa form5 = new UyeAnasayfa();
                 form5.Show();
                 this.Hide();
             }
             else
             {
                 this.Controls.Clear();
             } */

            bool blnfound = false;

            
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("Select * from uyebilgi where tc = '" + txtKullanıcıAdı.Text + "' and uye_sifre = '" + txtPassword.Text + "'", baglanti);
            //NpgsqlCommand komut1 = new NpgsqlCommand("Select * from userr where username= '" + txtKullanıcıAdı.Text + "' and password = '" + txtPassword.Text + "'", baglanti);
            NpgsqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                blnfound = true;

                UyeAnasayfa form5 = new UyeAnasayfa();
                form5.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
