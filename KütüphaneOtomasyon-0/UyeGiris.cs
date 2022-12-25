﻿using System;
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
            public static string deger = "";
            public static string ad = "";
            public static string soyad = "";

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
             NpgsqlCommand komut1 = new NpgsqlCommand("Select * from uyebilgi where tc = '" + txtKullanıcıAdı.Text + "' and uye_sifre = '" + txtPassword.Text + "'", baglanti);
             NpgsqlDataReader dr = komut1.ExecuteReader();
                if (dr.Read())
                {
                    deger = txtKullanıcıAdı.Text;
                    blnfound = true;
                 
                    baglanti.Close();
                 

                    baglanti.Open();
                    NpgsqlCommand komut2 = new NpgsqlCommand("SELECT uye_ad, uye_soyad FROM uyebilgi WHERE tc = '" + txtKullanıcıAdı.Text + "'",baglanti);
                    NpgsqlDataReader dr2 = komut2.ExecuteReader();

                    if (dr2.Read())
                    {
                        ad = dr2["uye_ad"].ToString();
                        soyad = dr2["uye_soyad"].ToString();
                        dr2.Close();

                    }
                    UyeAnasayfa form = new UyeAnasayfa();
                    form.Show();
                    this.Hide();
                    MessageBox.Show("Hoş Geldiniz. !!");
                }

                    if (blnfound == false)
                    {
                        MessageBox.Show("Tekrar Deneyin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
         dr.Close();
         baglanti.Close(); 
    //bu satırı kaldırmayı unutma!
        /* UyeAnasayfa form5 = new UyeAnasayfa();
         form5.Show();
         this.Hide(); */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeKayıt form4 = new UyeKayıt();
            form4.Show();
            this.Hide();
        }

        private void txtKullanıcıAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece rakam
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreUnuttum form5 = new SifreUnuttum();
            form5.ShowDialog();
        }
    }
}
