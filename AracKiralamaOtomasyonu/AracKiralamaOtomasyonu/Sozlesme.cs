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


namespace AracKiralamaOtomasyonu
{
    public partial class Sozlesme : DevExpress.XtraEditors.XtraForm
    {
        MySqlConnection conn = new MySqlConnection(@"Data Source=localhost; port=3306; Initial Catalog=arac_kiralama; User Id=root; password=");
        public Sozlesme()
        {
            InitializeComponent();
        }

        public void BosAracGetir()
        {
            conn.Open();

            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from araclar where durum='Boş'";
                cmd.ExecuteNonQuery();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbAracPlaka.Items.Add(dr["plaka"].ToString());
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }

            conn.Close();
        }

        public void TcGetir()
        {
            conn.Open();

            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from musteriler where tc like '" + txtTcAra.Text + "'";
                cmd.ExecuteNonQuery();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTc.Text = dr["tc"].ToString();
                    txtAd.Text = dr["ad"].ToString();
                    txtSoyad.Text = dr["soyad"].ToString();
                    txtTelefon.Text = dr["telefonNo"].ToString();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }

            conn.Close();
        }

        public void AracBilgiGetir()
        {
            conn.Open();

            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from araclar where plaka like '" + cmbAracPlaka.Text + "'";
                cmd.ExecuteNonQuery();
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    txtMarka.Text = dr["marka"].ToString();
                    txtSeri.Text = dr["seri"].ToString();
                    txtModel.Text = dr["yil"].ToString();
                    txtRenk.Text = dr["renk"].ToString();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }

            conn.Close();
        }

        public void Hesapla()
        {
            conn.Open();

            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from araclar where plaka like '" + cmbAracPlaka.Text + "'";
                cmd.ExecuteNonQuery();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if(cmbKira.SelectedIndex==0)
                    {
                        txtKiraUcret.Text = dr["kiraUcret"].ToString();
                    }
                    else if(cmbKira.SelectedIndex==1)
                    {
                        txtKiraUcret.Text = (int.Parse(dr["kiraUcret"].ToString()) * 0.85).ToString();
                    }
                    else if(cmbKira.SelectedIndex==2)
                    {
                        txtKiraUcret.Text = (int.Parse(dr["kiraUcret"].ToString()) * 0.65).ToString();
                    }
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
            MySqlDataAdapter da = new MySqlDataAdapter("select * from sozlesme", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Sozlesme_Load(object sender, EventArgs e)
        {
            BosAracGetir();
            Listele();
        }

        private void txtTc_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbAracPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "") foreach (Control item in groupControl1.Controls) if (item is TextEdit) item.Text = "";
            AracBilgiGetir();
        }

        private void cmbKira_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void txtTutar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gunHesap = DateTime.Parse(dateAlis.Text) - DateTime.Parse(dateCikis.Text);
            int gun = gunHesap.Days;
            txtGun.Text = gun.ToString();
            txtTutar.Text = (gun * double.Parse(txtKiraUcret.Text)).ToString();
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTcAra.Text = "";
            cmbAracPlaka.Text = "";
            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtEhliyetNo.Text = "";
            txtEhliyetTarih.Text = "";
            txtEhliyetYer.Text = "";
            txtMarka.Text = "";
            txtSeri.Text = "";
            txtModel.Text = "";
            txtRenk.Text = "";
            cmbKira.Text = "";
            txtKiraUcret.Text = "";
            txtGun.Text = "";
            txtTutar.Text = "";
            dateAlis.Text = DateTime.Now.ToString();
            dateCikis.Text = DateTime.Now.ToString();
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                MySqlCommand yeniKayit = new MySqlCommand("insert into sozlesme (tc,ad,soyad,telefon,ehliyetNo,ehliyetTarih,ehliyetYer,plaka,marka,seri,yil,renk,kiraSekli,kiraUcreti,gun,tutar,cikisTarihi,alisTarihi) values ('" + txtTc.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTelefon.Text + "','" + txtEhliyetNo.Text + "','" + txtEhliyetTarih.Text + "','" + txtEhliyetYer.Text + "','" + cmbAracPlaka.Text + "','" + txtMarka.Text + "','" + txtSeri.Text + "','" + txtModel.Text + "','" + txtRenk.Text + "','" + cmbKira.Text + "','" + txtKiraUcret.Text + "','" + txtGun.Text + "','" + txtTutar.Text + "','" + dateCikis.Text + "','" + dateAlis.Text + "')", conn);

                MySqlCommand durumGuncelle = conn.CreateCommand();
                durumGuncelle.CommandType = CommandType.Text;
                durumGuncelle.CommandText = "update araclar set durum='Dolu' where plaka='" + cmbAracPlaka.Text + "'";
                object i = null;
                object j = null;
                i = yeniKayit.ExecuteNonQuery();
                j = durumGuncelle.ExecuteNonQuery();

                if (i != null)
                {
                    if(j!=null)
                    {
                        MessageBox.Show("Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                    }
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Listele();
                }
                BosAracGetir();
            }
            catch
            {
                ;
            }

            conn.Close();
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
                txtEhliyetNo.Text = dr[4].ToString();
                txtEhliyetTarih.Text = dr[5].ToString();
                txtEhliyetYer.Text = dr[6].ToString();
                cmbAracPlaka.Text = dr[7].ToString();
                txtMarka.Text = dr[8].ToString();
                txtSeri.Text = dr[9].ToString();
                txtModel.Text = dr[10].ToString();
                txtRenk.Text = dr[11].ToString();
                cmbKira.Text = dr[12].ToString();
                txtKiraUcret.Text = dr[13].ToString();
                txtGun.Text = dr[14].ToString();
                txtTutar.Text = dr[15].ToString();
                dateCikis.Text = dr[16].ToString();
                dateAlis.Text = dr[17].ToString();
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control item in groupControl1.Controls) if (item is TextEdit) item.Text = "";
            TcGetir();
        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                MySqlCommand sozlesmeSil = conn.CreateCommand();
                sozlesmeSil.CommandType = CommandType.Text;
                sozlesmeSil.CommandText = "delete from sozlesme where plaka='" + cmbAracPlaka.Text + "'";
                MySqlCommand durumGuncelle = conn.CreateCommand();
                durumGuncelle.CommandType = CommandType.Text;
                durumGuncelle.CommandText = "update araclar set durum='Boş' where plaka='" + cmbAracPlaka.Text + "'";

                object i = null;
                object j = null;
                i = sozlesmeSil.ExecuteNonQuery();
                j = durumGuncelle.ExecuteNonQuery();
                if (i != null)
                {
                    if(j!=null)
                    {
                        MessageBox.Show("Araç Teslim Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        BosAracGetir();
                    }
                }

                else
                {
                    MessageBox.Show("İşlem Başarısız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    BosAracGetir();
                }
                BosAracGetir();
        }
            catch 
            {
                ;
            }

            conn.Close();
        }
        
    }
}
