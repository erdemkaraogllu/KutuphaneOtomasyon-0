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
            circularPictureBox1.BackColor = Color.Yellow;
        }

        private void circularPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.Transparent;
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
            circularPictureBox2.BackColor = Color.Yellow;
        }

        private void circularPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor = Color.Transparent;
        }

        private void cpKapat_MouseEnter(object sender, EventArgs e)
        {
            cpKapat.BackColor = Color.Red;
        }

        private void cpKapat_MouseLeave(object sender, EventArgs e)
        {
            cpKapat.BackColor = Color.Transparent;
        }

        private void cpKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
