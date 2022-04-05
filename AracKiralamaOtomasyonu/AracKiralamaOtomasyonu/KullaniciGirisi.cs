using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace AracKiralamaOtomasyonu
{
    public partial class KullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        MySqlConnection conn = new MySqlConnection(@"Data Source=localhost; port=3306; Initial Catalog=arac_kiralama; User Id=root; password=");
        int x;
        public KullaniciGirisi()
        {
            InitializeComponent();
            Kullanici_Bilgi();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            x = 0;
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kullanicilar where k_adi='" + txtKullaniciAdi.Text + "' and parola='" + txtSifre.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());

            if (x==0)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            else
            {
                Beni_Hatirla();
                AnaSayfa af = new AnaSayfa();
                af.lblHosgeldin.Text = "Hangar Otomative Hoş Geldin " + txtKullaniciAdi.Text;

                IslemGerceklestriliyor islem = new IslemGerceklestriliyor();
                islem.Show();

                MessageBox.Show("Giriş Başarılı", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                islem.Hide();
                this.Hide();
                af.Show();
            }
            conn.Close();
        }

        private void Kullanici_Bilgi()
        {
            if(Properties.Settings.Default.Kullanici_adi!=string.Empty)
            {
                if(Properties.Settings.Default.Beni_hatırla==true)
                {
                    txtKullaniciAdi.Text = Properties.Settings.Default.Kullanici_adi;
                    txtSifre.Text = Properties.Settings.Default.Sifre;
                    chkBeniHatirla.Checked = true;
                }
                else
                {
                    txtKullaniciAdi.Text = Properties.Settings.Default.Kullanici_adi;
                }
            }
        }

        private void Beni_Hatirla()
        {
            if(chkBeniHatirla.Checked)
            {
                Properties.Settings.Default.Kullanici_adi = txtKullaniciAdi.Text;
                Properties.Settings.Default.Sifre = txtSifre.Text;
                Properties.Settings.Default.Beni_hatırla = true;
                Properties.Settings.Default.Save();
            }

            else
            {
                Properties.Settings.Default.Kullanici_adi = "";
                Properties.Settings.Default.Sifre = "";
                Properties.Settings.Default.Beni_hatırla = false;
                Properties.Settings.Default.Save();
            }
        }
        private void KullaniciGirisi_Shown(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }

        private void llblSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum su = new SifremiUnuttum();
            su.ShowDialog();
        }
        
    }
}
