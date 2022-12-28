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
    public partial class UyeAnasayfa : Form


    {
        

        public UyeAnasayfa()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
            NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");
        

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
               // string sorgu = "select kitap_ad, yazar, tur, yayin_evi, basim, sayfa from kitap where not kitap_ad in(SELECT * FROM kitap WHERE kitap_ad like '" + txtAra.Text + "%')";
                string sorgu = "SELECT * FROM kitap WHERE kitap_ad like '" + txtAra.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "kutuphane");
                dgvData.DataSource = ds.Tables["kutuphane"];
                baglanti.Close();                             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama Hatası" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string deger1 = UyeGiris.deger;
            string degerAd = UyeGiris.ad;
            string degerSoyad = UyeGiris.soyad;

            label1.Text = degerAd + " " + degerSoyad;
            dgvDataOdunc.DataSource = yenileEmanet();
            dgvData.DataSource = yenileKitap();
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                txtAra.Clear();                
                string sorgu = "select kitap_ad, yazar, tur, yayin_evi, basim, sayfa from kitap where not kitap_ad in(select kitap_ad from  emanet_kitap)";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu , baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvData.DataSource = ds.Tables[0];               
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Listeleme Hatası"+ ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UyeGuncelleme form1 = new UyeGuncelleme();
            form1.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            try
            {
                string deger1 = UyeGiris.deger;
                bool sorgu = false;
                baglanti.Open();                               
                NpgsqlCommand komut1 = new NpgsqlCommand("SELECT * FROM emanet_kitap WHERE tc = '" + deger1 +"'", baglanti);
                NpgsqlDataReader dr = komut1.ExecuteReader();
                              
                if (dr.Read())               
                {
                    sorgu = true;
                    MessageBox.Show("Önce Emanet Kitabı Teslim Ediniz","HATA",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                dr.Close();
                baglanti.Close();

                if (sorgu == false)
                {
                    dr.Close();
                    baglanti.Close();
                    baglanti.Open();
                    string TC = UyeGiris.deger;
                    string KitapAd = dgvData.CurrentRow.Cells[0].Value.ToString();

                    /*                    
                    create or replace function emanet_al(_tc character varying, _kitap_ad character varying)
                    returns int as 
                    $$
                    begin
	                    insert into emanet_kitap(tc,kitap_ad,emanet_date,teslim_date)
	                    values(_tc, _kitap_ad, CURRENT_DATE, CURRENT_DATE+3);
	                    if found then --Başarılı
		                    return 1;
	                    else return 0; --Hata
	                    end if;
                    end
                    $$
                    language plpgsql 
                    */

                    NpgsqlCommand komut = new NpgsqlCommand("SELECT FROM emanet_al(:_tc, :_kitap_ad)", baglanti);
                    komut.Parameters.AddWithValue("_tc", TC);
                    komut.Parameters.AddWithValue("_kitap_ad", KitapAd);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kitap Emanet Alındı !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvData.DataSource = yenileKitap();
                    dgvDataOdunc.DataSource = yenileEmanet();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Emanet Alma Hatası !", "HATA " +  ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        DataTable yenileKitap()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select kitap_ad, yazar, tur, yayin_evi, basim, sayfa from kitap where not kitap_ad in(select kitap_ad from  emanet_kitap)", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        DataTable yenileEmanet()
        {
            string deger1 = UyeGiris.deger;
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select kitap_ad, age(teslim_date,current_date) from emanet_kitap WHERE tc like '" + deger1 + "%'", baglanti);
            DataTable tablo1 = new DataTable();
            da.Fill(tablo1);
            baglanti.Close();
            return tablo1;
        }       

        private void pbOkunanKitaplar_MouseEnter(object sender, EventArgs e)
        {
            pbOkunanKitaplar.BackColor = Color.Red;
        }

        private void pbOkunanKitaplar_MouseLeave(object sender, EventArgs e)
        {
            pbOkunanKitaplar.BackColor = Color.FromArgb(153, 217, 234);
        }

        private void pbOkunanKitaplar_Click(object sender, EventArgs e)
        {
            var form1 = new OkunanKitap
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            form1.ShowDialog(this);
        }

        private void circularPictureBox3_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }

        private void circularPictureBox3_MouseEnter(object sender, EventArgs e)
        {
            circularPictureBox3.BackColor = Color.Red;
        }

        private void circularPictureBox3_MouseLeave(object sender, EventArgs e)
        {
            circularPictureBox3.BackColor = Color.Transparent;
        }

      
    }
}
