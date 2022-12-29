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
    public partial class OkunanKitap : Form
    {
        public OkunanKitap()
        {
            InitializeComponent();
        }
        string deger1 = UyeGiris.deger;
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");

        private void OkunanKitap_Load(object sender, EventArgs e)
        {
            try
            {
               // string deger1 = UyeGiris.deger;
                string sorgu = "SELECT kitap_ad FROM okunan_kitap WHERE tc like '" + deger1 + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "okunankitap");
                dgvOkunanKitap.DataSource = ds.Tables["okunankitap"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void circularPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox1.BackColor = Color.Red;
            circularPictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void circularPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox1.BorderStyle = BorderStyle.None;
            circularPictureBox1.BackColor = Color.Transparent;
        }
    }
}
