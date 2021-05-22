namespace AracKiralamaOtomasyonu
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.lblKullanici = new DevExpress.XtraEditors.LabelControl();
            this.lblMail = new DevExpress.XtraEditors.LabelControl();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.lblSifreHatirlat = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblKullanici.Appearance.Options.UseForeColor = true;
            this.lblKullanici.Location = new System.Drawing.Point(40, 71);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(55, 13);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // lblMail
            // 
            this.lblMail.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblMail.Appearance.Options.UseForeColor = true;
            this.lblMail.Location = new System.Drawing.Point(40, 110);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(25, 13);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Gmail";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(113, 68);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(205, 20);
            this.txtKullanici.TabIndex = 2;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(113, 107);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(205, 20);
            this.txtMail.TabIndex = 3;
            // 
            // btnGonder
            // 
            this.btnGonder.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGonder.Appearance.Options.UseForeColor = true;
            this.btnGonder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnGonder.Location = new System.Drawing.Point(243, 152);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Location = new System.Drawing.Point(330, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(21, 22);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "X";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblSifreHatirlat
            // 
            this.lblSifreHatirlat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreHatirlat.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblSifreHatirlat.Appearance.Options.UseFont = true;
            this.lblSifreHatirlat.Appearance.Options.UseForeColor = true;
            this.lblSifreHatirlat.Location = new System.Drawing.Point(40, 155);
            this.lblSifreHatirlat.Name = "lblSifreHatirlat";
            this.lblSifreHatirlat.Size = new System.Drawing.Size(0, 16);
            this.lblSifreHatirlat.TabIndex = 6;
            this.lblSifreHatirlat.Click += new System.EventHandler(this.lblSifreHatirlat_Click);
            // 
            // SifremiUnuttum
            // 
            this.AcceptButton = this.btnGonder;
            this.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(363, 211);
            this.Controls.Add(this.lblSifreHatirlat);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblKullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifremi Unuttum";
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblKullanici;
        private DevExpress.XtraEditors.LabelControl lblMail;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        public DevExpress.XtraEditors.LabelControl lblSifreHatirlat;
    }
}