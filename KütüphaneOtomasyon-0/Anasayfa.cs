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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void circularPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.Green;
            circularPictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void circularPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.Transparent;
            circularPictureBox1.BorderStyle = BorderStyle.None;
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            YoneticiGiris form1 = new YoneticiGiris();
            form1.Show();
            this.Hide();
        }

        private void circularPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void circularPictureBox2_Click_1(object sender, EventArgs e)
        {
            UyeGiris form2 = new UyeGiris();
            form2.Show();
            this.Hide();

        }

        private void circularPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor = Color.Green;
            circularPictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void circularPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor = Color.Transparent;
            circularPictureBox2.BorderStyle= BorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void linkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeKayıt form4 = new UyeKayıt();
            form4.ShowDialog();
            
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
