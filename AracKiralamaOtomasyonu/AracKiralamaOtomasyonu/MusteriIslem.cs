using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;

namespace AracKiralamaOtomasyonu
{
    public partial class MusteriIslem : DevExpress.XtraEditors.XtraForm
    {
        MySqlConnection conn = new MySqlConnection(@"Data Source=localhost; port=3306; Initial Catalog=arac_kiralama; User Id=root; password=zx79X3qw");

        public MusteriIslem()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                MySqlCommand yeniKayit = new MySqlCommand("insert into musteriler(tc,ad,soyad,telefonNo,adres,gmail) values ('" + txtTc.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTelefon.Text + "','" + txtAdres.Text + "','" + txtGmail.Text + "')", conn);
                object i = null;
                i = yeniKayit.ExecuteNonQuery();

                if(i!=null)
                {
                    MessageBox.Show("Ekleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                else
                {
                    MessageBox.Show("İşlem başarısız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }

            conn.Close();
        }

        public void Listele()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from musteriler", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                txtTc.Text = dr[0].ToString();
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                txtTelefon.Text = dr[3].ToString();
                txtAdres.Text = dr[4].ToString();
                txtGmail.Text = dr[5].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                MySqlCommand kayitSil = conn.CreateCommand();
                kayitSil.CommandType = CommandType.Text;
                kayitSil.CommandText = "DELETE FROM musteriler WHERE tc='" + txtTc.Text + "'";
                object i = null;
                i = kayitSil.ExecuteNonQuery();

                if (i != null)
                {
                    MessageBox.Show("Silme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                else
                {
                    MessageBox.Show("İşlem başarısız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ht)
            {
                MessageBox.Show("Hata: " + ht.Message);
            }

            conn.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
            txtGmail.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                MySqlCommand guncelle = conn.CreateCommand();
                guncelle.CommandType = CommandType.Text;
                guncelle.CommandText = "UPDATE musteriler SET ad='" + txtAd.Text + "',soyad='" + txtSoyad.Text + "',telefonNo='" + txtTelefon.Text + "',adres='" + txtAdres.Text + "',gmail='" + txtGmail.Text + "' where tc='" + txtTc.Text + "'";

                object i = null;
                i = guncelle.ExecuteNonQuery();

                if (i != null)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                else
                {
                    MessageBox.Show("İşlem başarısız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }

            conn.Close();
        }
    }
}