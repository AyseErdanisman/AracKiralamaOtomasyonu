namespace AracKiralamaOtomasyonu
{
    partial class KullaniciGirisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblBaslik1 = new DevExpress.XtraEditors.LabelControl();
            this.lblBaslik2 = new DevExpress.XtraEditors.LabelControl();
            this.lblKullanici = new DevExpress.XtraEditors.LabelControl();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.chkBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.llblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chkBeniHatirla.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(733, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 26);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblBaslik1
            // 
            this.lblBaslik1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik1.Appearance.Options.UseFont = true;
            this.lblBaslik1.Location = new System.Drawing.Point(483, 66);
            this.lblBaslik1.Name = "lblBaslik1";
            this.lblBaslik1.Size = new System.Drawing.Size(240, 25);
            this.lblBaslik1.TabIndex = 1;
            this.lblBaslik1.Text = "Hangar Ararç Kiralama";
            // 
            // lblBaslik2
            // 
            this.lblBaslik2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik2.Appearance.Options.UseFont = true;
            this.lblBaslik2.Location = new System.Drawing.Point(483, 92);
            this.lblBaslik2.Name = "lblBaslik2";
            this.lblBaslik2.Size = new System.Drawing.Size(114, 23);
            this.lblBaslik2.TabIndex = 2;
            this.lblBaslik2.Text = "Kullanıcı Girişi";
            // 
            // lblKullanici
            // 
            this.lblKullanici.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Appearance.Options.UseFont = true;
            this.lblKullanici.Location = new System.Drawing.Point(483, 129);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(72, 18);
            this.lblKullanici.TabIndex = 3;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.Location = new System.Drawing.Point(483, 183);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 18);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre";
            // 
            // chkBeniHatirla
            // 
            this.chkBeniHatirla.Location = new System.Drawing.Point(483, 235);
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            this.chkBeniHatirla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBeniHatirla.Properties.Appearance.Options.UseFont = true;
            this.chkBeniHatirla.Properties.Caption = "Beni Hatırla";
            this.chkBeniHatirla.Size = new System.Drawing.Size(75, 19);
            this.chkBeniHatirla.TabIndex = 8;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(575, 260);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(85, 30);
            this.btnGiris.TabIndex = 10;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(483, 150);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(177, 22);
            this.txtKullaniciAdi.TabIndex = 11;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(483, 204);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(177, 22);
            this.txtSifre.TabIndex = 12;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // llblSifremiUnuttum
            // 
            this.llblSifremiUnuttum.ActiveLinkColor = System.Drawing.Color.Lime;
            this.llblSifremiUnuttum.AutoSize = true;
            this.llblSifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.llblSifremiUnuttum.Location = new System.Drawing.Point(572, 237);
            this.llblSifremiUnuttum.Name = "llblSifremiUnuttum";
            this.llblSifremiUnuttum.Size = new System.Drawing.Size(88, 13);
            this.llblSifremiUnuttum.TabIndex = 13;
            this.llblSifremiUnuttum.TabStop = true;
            this.llblSifremiUnuttum.Text = "Şifremi Unuttum?";
            this.llblSifremiUnuttum.VisitedLinkColor = System.Drawing.Color.DarkMagenta;
            this.llblSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSifremiUnuttum_LinkClicked);
            // 
            // KullaniciGirisi
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::AracKiralamaOtomasyonu.Properties.Resources.mercedes_benz_amg_gt_r_roadster_1;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(770, 519);
            this.Controls.Add(this.llblSifremiUnuttum);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.chkBeniHatirla);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblBaslik2);
            this.Controls.Add(this.lblBaslik1);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KullaniciGirisi_Load);
            this.Shown += new System.EventHandler(this.KullaniciGirisi_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chkBeniHatirla.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private DevExpress.XtraEditors.LabelControl lblBaslik1;
        private DevExpress.XtraEditors.LabelControl lblBaslik2;
        private DevExpress.XtraEditors.LabelControl lblKullanici;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.CheckEdit chkBeniHatirla;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.LinkLabel llblSifremiUnuttum;
        private System.Windows.Forms.TextBox txtSifre;
    }
}

