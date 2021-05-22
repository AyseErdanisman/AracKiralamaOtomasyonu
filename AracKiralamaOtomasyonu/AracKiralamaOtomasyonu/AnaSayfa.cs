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

namespace AracKiralamaOtomasyonu
{
    public partial class AnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {

        }

        private void lblAnaSayfa_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        MusteriIslem ml;
        private void btnMusteriListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ml==null)
            {
                ml = new MusteriIslem();
                ml.MdiParent = this;
                ml.Show();
            }
        }

        AracIslem ai;
        private void btnAracIslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ai==null)
            {
                ai = new AracIslem();
                ai.MdiParent = this;
                ai.Show();
            }

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        Sozlesme sf;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(sf==null)
            {
                sf = new Sozlesme();
                sf.MdiParent = this;
                sf.Show();
            }
        }

        private void lblHosgeldin_Click(object sender, EventArgs e)
        {

        }
    }
}