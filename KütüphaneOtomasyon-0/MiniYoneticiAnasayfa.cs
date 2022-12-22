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
    public partial class MiniYoneticiAnasayfa : Form
    {
        public MiniYoneticiAnasayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");
        private void MiniYoneticiAnasayfa_Load(object sender, EventArgs e)
        {
            NpgsqlCommand uyesayısı = new NpgsqlCommand("SELECT count(id) FROM kitap", baglanti);
            baglanti.Open();
            string uye = uyesayısı.ExecuteScalar().ToString();
            baglanti.Close();
            lblKitapSayisi.Text= uye;

            NpgsqlCommand kitapsayisi = new NpgsqlCommand("SELECT count(id) FROM uyebilgi", baglanti);
            baglanti.Open();
            string kitap = kitapsayisi.ExecuteScalar().ToString();
            baglanti.Close(); 
            lblKullanıcıSayisi.Text= kitap;

        }
    }
}
