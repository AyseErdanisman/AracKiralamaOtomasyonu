namespace AracKiralamaOtomasyonu
{
    partial class AracIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracIslem));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.lblDurum = new DevExpress.XtraEditors.LabelControl();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.cmbSeri = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.txtRenk = new DevExpress.XtraEditors.TextEdit();
            this.txtKira = new DevExpress.XtraEditors.TextEdit();
            this.txtPlaka = new DevExpress.XtraEditors.TextEdit();
            this.lblKira = new DevExpress.XtraEditors.LabelControl();
            this.lblRenk = new DevExpress.XtraEditors.LabelControl();
            this.lblYakit = new DevExpress.XtraEditors.LabelControl();
            this.lblModel = new DevExpress.XtraEditors.LabelControl();
            this.lblSeri = new DevExpress.XtraEditors.LabelControl();
            this.lblMarka = new DevExpress.XtraEditors.LabelControl();
            this.lblPlaka = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblDurumListele = new DevExpress.XtraEditors.LabelControl();
            this.cmbDurumListele = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKira.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(509, 376);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Aquamarine;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.LimeGreen;
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.cmbDurum);
            this.groupControl1.Controls.Add(this.lblDurum);
            this.groupControl1.Controls.Add(this.cmbYakit);
            this.groupControl1.Controls.Add(this.cmbSeri);
            this.groupControl1.Controls.Add(this.cmbMarka);
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.txtModel);
            this.groupControl1.Controls.Add(this.txtRenk);
            this.groupControl1.Controls.Add(this.txtKira);
            this.groupControl1.Controls.Add(this.txtPlaka);
            this.groupControl1.Controls.Add(this.lblKira);
            this.groupControl1.Controls.Add(this.lblRenk);
            this.groupControl1.Controls.Add(this.lblYakit);
            this.groupControl1.Controls.Add(this.lblModel);
            this.groupControl1.Controls.Add(this.lblSeri);
            this.groupControl1.Controls.Add(this.lblMarka);
            this.groupControl1.Controls.Add(this.lblPlaka);
            this.groupControl1.Location = new System.Drawing.Point(531, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(360, 433);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(174, 382);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 41);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(154, 181);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(119, 28);
            this.btnTemizle.TabIndex = 28;
            this.btnTemizle.Text = "Hücreleri Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(268, 382);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(67, 41);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Boş",
            "Dolu"});
            this.cmbDurum.Location = new System.Drawing.Point(258, 147);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(77, 21);
            this.cmbDurum.TabIndex = 25;
            // 
            // lblDurum
            // 
            this.lblDurum.Location = new System.Drawing.Point(208, 150);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(31, 13);
            this.lblDurum.TabIndex = 24;
            this.lblDurum.Text = "Durum";
            // 
            // cmbYakit
            // 
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "LPG",
            "Hibrit"});
            this.cmbYakit.Location = new System.Drawing.Point(258, 113);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(77, 21);
            this.cmbYakit.TabIndex = 23;
            // 
            // cmbSeri
            // 
            this.cmbSeri.FormattingEnabled = true;
            this.cmbSeri.Location = new System.Drawing.Point(90, 80);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(77, 21);
            this.cmbSeri.TabIndex = 22;
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Citroen",
            "Fiat",
            "Mercedes - Benz",
            "Toyota ",
            "Volvo"});
            this.cmbMarka.Location = new System.Drawing.Point(258, 46);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(77, 21);
            this.cmbMarka.TabIndex = 21;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(102, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 271);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(81, 38);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "Fotoğraf\r\nEkle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(102, 382);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(66, 41);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(258, 80);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(77, 20);
            this.txtModel.TabIndex = 11;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(90, 114);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(77, 20);
            this.txtRenk.TabIndex = 10;
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(90, 147);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(77, 20);
            this.txtKira.TabIndex = 9;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(90, 47);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(77, 20);
            this.txtPlaka.TabIndex = 7;
            // 
            // lblKira
            // 
            this.lblKira.Location = new System.Drawing.Point(52, 150);
            this.lblKira.Name = "lblKira";
            this.lblKira.Size = new System.Drawing.Size(18, 13);
            this.lblKira.TabIndex = 6;
            this.lblKira.Text = "Kira";
            // 
            // lblRenk
            // 
            this.lblRenk.Location = new System.Drawing.Point(46, 117);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(24, 13);
            this.lblRenk.TabIndex = 5;
            this.lblRenk.Text = "Renk";
            // 
            // lblYakit
            // 
            this.lblYakit.Location = new System.Drawing.Point(216, 116);
            this.lblYakit.Name = "lblYakit";
            this.lblYakit.Size = new System.Drawing.Size(23, 13);
            this.lblYakit.TabIndex = 4;
            this.lblYakit.Text = "Yakıt";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(216, 82);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(28, 13);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model";
            // 
            // lblSeri
            // 
            this.lblSeri.Location = new System.Drawing.Point(48, 84);
            this.lblSeri.Name = "lblSeri";
            this.lblSeri.Size = new System.Drawing.Size(18, 13);
            this.lblSeri.TabIndex = 2;
            this.lblSeri.Text = "Seri";
            // 
            // lblMarka
            // 
            this.lblMarka.Location = new System.Drawing.Point(215, 49);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(29, 13);
            this.lblMarka.TabIndex = 1;
            this.lblMarka.Text = "Marka";
            // 
            // lblPlaka
            // 
            this.lblPlaka.Location = new System.Drawing.Point(48, 50);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(25, 13);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Plaka";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblDurumListele
            // 
            this.lblDurumListele.Location = new System.Drawing.Point(12, 12);
            this.lblDurumListele.Name = "lblDurumListele";
            this.lblDurumListele.Size = new System.Drawing.Size(133, 13);
            this.lblDurumListele.TabIndex = 2;
            this.lblDurumListele.Text = "Araç Durumuna Göre Listele";
            // 
            // cmbDurumListele
            // 
            this.cmbDurumListele.FormattingEnabled = true;
            this.cmbDurumListele.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Dolu Araçlar",
            "Boş Araçlar"});
            this.cmbDurumListele.Location = new System.Drawing.Point(151, 9);
            this.cmbDurumListele.Name = "cmbDurumListele";
            this.cmbDurumListele.Size = new System.Drawing.Size(121, 21);
            this.cmbDurumListele.TabIndex = 3;
            this.cmbDurumListele.SelectedIndexChanged += new System.EventHandler(this.cmbDurumListele_SelectedIndexChanged);
            // 
            // AracIslem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 434);
            this.Controls.Add(this.cmbDurumListele);
            this.Controls.Add(this.lblDurumListele);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "AracIslem";
            this.Text = "Araç İşlemleri";
            this.Load += new System.EventHandler(this.AracIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKira.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.TextEdit txtRenk;
        private DevExpress.XtraEditors.TextEdit txtKira;
        private DevExpress.XtraEditors.TextEdit txtPlaka;
        private DevExpress.XtraEditors.LabelControl lblKira;
        private DevExpress.XtraEditors.LabelControl lblRenk;
        private DevExpress.XtraEditors.LabelControl lblYakit;
        private DevExpress.XtraEditors.LabelControl lblModel;
        private DevExpress.XtraEditors.LabelControl lblSeri;
        private DevExpress.XtraEditors.LabelControl lblMarka;
        private DevExpress.XtraEditors.LabelControl lblPlaka;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.ComboBox cmbSeri;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbDurum;
        private DevExpress.XtraEditors.LabelControl lblDurum;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.LabelControl lblDurumListele;
        private System.Windows.Forms.ComboBox cmbDurumListele;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    }
}