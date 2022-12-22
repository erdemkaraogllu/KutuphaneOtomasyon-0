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

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.White;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YoneticiAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form1 = new MiniYoneticiAnasayfa
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            form1.ShowDialog(this);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form2 = new MiniYoneticiKitap
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            form2.ShowDialog(this);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var form3 = new MiniYoneticiUye
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            form3.ShowDialog(this);
        }
    }
}
