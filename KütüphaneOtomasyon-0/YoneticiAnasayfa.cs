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
    public partial class YoneticiAnasayfa : Form
    {
        public YoneticiAnasayfa()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YoneticiAnasayfa_Load(object sender, EventArgs e)
        {
        
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }

        private void circularPictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor= Color.Red;
            circularPictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor= Color.Transparent;
            circularPictureBox1.BorderStyle = BorderStyle.None;
        }

        private void circularPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor = Color.White;
            circularPictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox2.BackColor= Color.Transparent;
            circularPictureBox2.BorderStyle= BorderStyle.None;
        }

        private void circularPictureBox2_Click(object sender, EventArgs e)
        {
            var form3 = new MiniYoneticiUye
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            form3.ShowDialog(this);
        }

        private void circularPictureBox4_Click(object sender, EventArgs e)
        {
            var form1 = new MiniYoneticiAnasayfa
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            form1.ShowDialog(this);
        }

        private void circularPictureBox3_Click(object sender, EventArgs e)
        {
            var form2 = new MiniYoneticiKitap
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            form2.ShowDialog(this);
        }

        private void circularPictureBox4_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox4.BackColor = Color.White;
            circularPictureBox4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox4_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox4.BackColor = Color.Transparent;
            circularPictureBox4.BorderStyle = BorderStyle.None;
        }

        private void circularPictureBox3_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox3.BackColor = Color.White;
            circularPictureBox3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox3_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox3.BackColor= Color.Transparent;
            circularPictureBox3.BorderStyle = BorderStyle.None;
        }
    }
}
