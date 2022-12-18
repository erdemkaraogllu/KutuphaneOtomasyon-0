using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyon_0
{
    internal class Baglanti
    {
        public NpgsqlConnection baglan = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=Kutuphane_Otomasyonu;");
        
        public void Baslat()
        {
            try 
            {
                baglan.Open();
                if (baglan.State != ConnectionState.Closed)
                { }
                else
                    MessageBox.Show("Bağlantı Yapılamadı !");

            }
            catch(Exception ex)
            { 
                MessageBox.Show("Hata! " + ex.Message, "Hata Oluştu !",MessageBoxButtons.OK,MessageBoxIcon.Error);               
            }
        }

        public void Bitir()
        {
            try 
            {
                baglan.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Hata! " + ex.Message, "Hata Oluştu !", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        //işlemler
        
    }


}
