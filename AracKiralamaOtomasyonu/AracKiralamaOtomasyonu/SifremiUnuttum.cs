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
    public partial class SifremiUnuttum : DevExpress.XtraEditors.XtraForm
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {

            if (txtKullanici.Text!="" && txtMail.Text!="")
            {
                MySqlConnection conn = new MySqlConnection(@"Data Source=localhost; port=3306; Initial Catalog=arac_kiralama; User Id=root; password=");
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from kullanicilar where k_adi='" + txtKullanici.Text + "' and mail='" + txtMail.Text + "'";

                MySqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    lblSifreHatirlat.Text ="Şifreniz: " + dr.GetValue(1).ToString();

                }
                else
                {
                    lblSifreHatirlat.Text = "Kullanıcı adı ve gmail eşleşmedi";
                }

                conn.Close();
            }

            else
            {
                lblSifreHatirlat.Text = "Lüütfen boşlukları eksiksiz doldurunuz.";
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            
        }

        private void lblSifreHatirlat_Click(object sender, EventArgs e)
        {

        }
    }
}
