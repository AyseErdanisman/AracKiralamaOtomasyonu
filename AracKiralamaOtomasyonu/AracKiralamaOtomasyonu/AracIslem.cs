using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.IO;

namespace AracKiralamaOtomasyonu
{
    public partial class AracIslem : DevExpress.XtraEditors.XtraForm
    {
        MySqlConnection conn = new MySqlConnection(@"Data Source=localhost; port=3306; Initial Catalog=arac_kiralama; User Id=root; password=");
        MySqlCommand cmd = new MySqlCommand();
        public void Listele()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from araclar", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }


        public AracIslem()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSeri.Items.Clear();
                if (cmbMarka.SelectedIndex == 0)
                {
                    cmbSeri.Items.Add("A1");
                    cmbSeri.Items.Add("A3");
                    cmbSeri.Items.Add("A4");
                    cmbSeri.Items.Add("A5");
                    cmbSeri.Items.Add("A6");
                    cmbSeri.Items.Add("A7");
                    cmbSeri.Items.Add("A8");
                    cmbSeri.Items.Add("R8");
                    cmbSeri.Items.Add("RS");
                    cmbSeri.Items.Add("S");
                    cmbSeri.Items.Add("TT");
                    cmbSeri.Items.Add("80");
                    cmbSeri.Items.Add("100");
                }

                else if (cmbMarka.SelectedIndex == 1)
                {
                    cmbSeri.Items.Add("1");
                    cmbSeri.Items.Add("2");
                    cmbSeri.Items.Add("3");
                    cmbSeri.Items.Add("4");
                    cmbSeri.Items.Add("5");
                    cmbSeri.Items.Add("6");
                    cmbSeri.Items.Add("7");
                    cmbSeri.Items.Add("i");
                    cmbSeri.Items.Add("M");
                    cmbSeri.Items.Add("Z");
                }

                else if (cmbMarka.SelectedIndex == 2)
                {
                    cmbSeri.Items.Add("AX");
                    cmbSeri.Items.Add("BX");
                    cmbSeri.Items.Add("C1");
                    cmbSeri.Items.Add("C2");
                    cmbSeri.Items.Add("C3");
                    cmbSeri.Items.Add("C3 Picasso");
                    cmbSeri.Items.Add("C4");
                    cmbSeri.Items.Add("C4 Grand Picasso");
                    cmbSeri.Items.Add("C4 Picasso");
                    cmbSeri.Items.Add("C5");
                    cmbSeri.Items.Add("C8");
                    cmbSeri.Items.Add("C-Elysee");
                    cmbSeri.Items.Add("Xantia");
                    cmbSeri.Items.Add("Xsara");
                    cmbSeri.Items.Add("ZX");
                }

                else if (cmbMarka.SelectedIndex == 3)
                {
                    cmbSeri.Items.Add("126 Bis");
                    cmbSeri.Items.Add("500 Ailesi");
                    cmbSeri.Items.Add("Albea");
                    cmbSeri.Items.Add("Brava");
                    cmbSeri.Items.Add("Bravo");
                    cmbSeri.Items.Add("Coupe");
                    cmbSeri.Items.Add("Croma");
                    cmbSeri.Items.Add("Egea");
                    cmbSeri.Items.Add("Idea");
                    cmbSeri.Items.Add("Linea");
                    cmbSeri.Items.Add("Marea");
                    cmbSeri.Items.Add("Palio");
                    cmbSeri.Items.Add("Panda");
                    cmbSeri.Items.Add("Punto");
                    cmbSeri.Items.Add("Regata");
                    cmbSeri.Items.Add("Sedici");
                    cmbSeri.Items.Add("Siena");
                    cmbSeri.Items.Add("Stilo");
                    cmbSeri.Items.Add("Tempra");
                    cmbSeri.Items.Add("Tipo");
                    cmbSeri.Items.Add("Uno");
                }

                else if (cmbMarka.SelectedIndex == 4)
                {
                    cmbSeri.Items.Add("A");
                    cmbSeri.Items.Add("B");
                    cmbSeri.Items.Add("C");
                    cmbSeri.Items.Add("CL");
                    cmbSeri.Items.Add("CLA");
                    cmbSeri.Items.Add("CLC");
                    cmbSeri.Items.Add("CLK");
                    cmbSeri.Items.Add("CLS");
                    cmbSeri.Items.Add("E");
                    cmbSeri.Items.Add("Maybach S");
                    cmbSeri.Items.Add("R");
                    cmbSeri.Items.Add("S");
                    cmbSeri.Items.Add("SL");
                    cmbSeri.Items.Add("SLC");
                    cmbSeri.Items.Add("SLK");
                    cmbSeri.Items.Add("190");
                    cmbSeri.Items.Add("200");
                    cmbSeri.Items.Add("230");
                    cmbSeri.Items.Add("240");
                    cmbSeri.Items.Add("250");
                    cmbSeri.Items.Add("260");
                    cmbSeri.Items.Add("280");
                    cmbSeri.Items.Add("300");
                    cmbSeri.Items.Add("320");
                    cmbSeri.Items.Add("420");
                    cmbSeri.Items.Add("600");
                }

                else if (cmbMarka.SelectedIndex == 5)
                {
                    cmbSeri.Items.Add("Auris");
                    cmbSeri.Items.Add("Avensis");
                    cmbSeri.Items.Add("Camry");
                    cmbSeri.Items.Add("Carina");
                    cmbSeri.Items.Add("Corolla");
                    cmbSeri.Items.Add("Corona");
                    cmbSeri.Items.Add("GT 86");
                    cmbSeri.Items.Add("Prius");
                    cmbSeri.Items.Add("Starlet");
                    cmbSeri.Items.Add("Urban Cruiser");
                    cmbSeri.Items.Add("Verso");
                    cmbSeri.Items.Add("Yaris");
                }

                else if (cmbMarka.SelectedIndex == 6)
                {
                    cmbSeri.Items.Add("C30");
                    cmbSeri.Items.Add("C70");
                    cmbSeri.Items.Add("S40");
                    cmbSeri.Items.Add("S60");
                    cmbSeri.Items.Add("S70");
                    cmbSeri.Items.Add("S80");
                    cmbSeri.Items.Add("S90");
                    cmbSeri.Items.Add("V40");
                    cmbSeri.Items.Add("V40 Cross Country");
                    cmbSeri.Items.Add("V50");
                    cmbSeri.Items.Add("V60");
                    cmbSeri.Items.Add("V60 Cross Country");
                    cmbSeri.Items.Add("V70");
                    cmbSeri.Items.Add("V90 Cross Country");
                    cmbSeri.Items.Add("460");
                    cmbSeri.Items.Add("850");
                    cmbSeri.Items.Add("940");
                    cmbSeri.Items.Add("960");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                MySqlCommand yeniKayit = new MySqlCommand("insert into araclar(plaka,marka,seri,yil,renk,yakit,kiraUcret,fotograf,tarih,durum) values ('" + txtPlaka.Text + "','" + cmbMarka.Text + "','" + cmbSeri.Text + "','" + txtModel.Text + "','" + txtRenk.Text + "','" + cmbYakit.Text + "','" + int.Parse(txtKira.Text) + "','" + pictureBox1.ImageLocation + "','" + DateTime.Now + "','" + cmbDurum.Text + "')", conn);
                object i = null;
                i = yeniKayit.ExecuteNonQuery();

                if (i != null)
                {
                    MessageBox.Show("Ekleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                else
                {
                    MessageBox.Show("İşlem başarısız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                }
            }
            catch (Exception ht)
            {
                MessageBox.Show("Hata: " + ht.Message);
            }
            conn.Close();
        }

        private void AracIslem_Load(object sender, EventArgs e)
        {
            Listele();
            cmbDurumListele.SelectedIndex = 0;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                txtPlaka.Text = dr[0].ToString();
                cmbMarka.Text = dr[1].ToString();
                cmbSeri.Text = dr[2].ToString();
                txtModel.Text = dr[3].ToString();
                txtRenk.Text = dr[4].ToString();
                cmbYakit.Text = dr[5].ToString();
                txtKira.Text = dr[6].ToString();
                cmbDurum.Text = dr[9].ToString();
                pictureBox1.ImageLocation = dr[7].ToString();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                MySqlCommand kayitSil = conn.CreateCommand();
                kayitSil.CommandType = CommandType.Text;
                kayitSil.CommandText = "DELETE FROM araclar WHERE plaka='"+txtPlaka.Text+"'";
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
            txtPlaka.Text = "";
            cmbMarka.Text = "";
            cmbSeri.Text = "";
            txtModel.Text = "";
            txtRenk.Text = "";
            cmbYakit.Text = "";
            txtKira.Text = "";
            cmbDurum.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                MySqlCommand guncelle = conn.CreateCommand();
                guncelle.CommandType = CommandType.Text;
                guncelle.CommandText = "UPDATE araclar SET marka='" + cmbMarka.Text + "',seri='" + cmbSeri.Text + "',yil='" + txtModel.Text + "',renk='" + txtRenk.Text + "',yakit='" + cmbYakit.Text + "',kiraUcret='" + int.Parse(txtKira.Text) + "',fotograf='" + pictureBox1.ImageLocation + "',tarih='" + DateTime.Now + "',durum='" + cmbDurum.Text + "' where plaka='" + txtPlaka.Text + "'";

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

            Listele();
            conn.Close();
        }

        private void cmbDurumListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbDurumListele.SelectedIndex==0)
                {
                    Listele();
                }

                else if(cmbDurumListele.SelectedIndex==1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from araclar where durum='Dolu'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }

                else if(cmbDurumListele.SelectedIndex==2)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from araclar where durum='Boş'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
