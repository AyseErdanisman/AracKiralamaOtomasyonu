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
    public partial class IslemGerceklestriliyor : DevExpress.XtraEditors.XtraForm
    {
        public IslemGerceklestriliyor()
        {
            InitializeComponent();
        }

        private void IslemGerceklestriliyor_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            progressBarControl1.EditValue = x;
        }

        private void progressBarControl1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}