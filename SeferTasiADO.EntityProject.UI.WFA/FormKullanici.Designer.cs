namespace SeferTasiADO.EntityProject.UI.WFA
{
    partial class FormKullanici
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
            this.SiparisOlustur = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFirmaPuani = new System.Windows.Forms.Label();
            this.lFirmaPuani = new System.Windows.Forms.Label();
            this.cbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.cbFirmaKategori = new System.Windows.Forms.ComboBox();
            this.cbRestoran = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiparisiOnayla = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.dtpIstenenTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.nAdet = new System.Windows.Forms.NumericUpDown();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnPuanVer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPuan = new System.Windows.Forms.ComboBox();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.SiparisOlustur.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SiparisOlustur
            // 
            this.SiparisOlustur.Controls.Add(this.tabPage1);
            this.SiparisOlustur.Controls.Add(this.tabPage2);
            this.SiparisOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SiparisOlustur.Location = new System.Drawing.Point(34, 12);
            this.SiparisOlustur.Name = "SiparisOlustur";
            this.SiparisOlustur.SelectedIndex = 0;
            this.SiparisOlustur.Size = new System.Drawing.Size(1200, 614);
            this.SiparisOlustur.TabIndex = 0;
            this.SiparisOlustur.SelectedIndexChanged += new System.EventHandler(this.SiparisOlustur_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::SeferTasiADO.EntityProject.UI.WFA.Properties.Resources.yemeksepeti_com;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblFirmaPuani);
            this.tabPage1.Controls.Add(this.lFirmaPuani);
            this.tabPage1.Controls.Add(this.cbOdemeTipi);
            this.tabPage1.Controls.Add(this.cbFirmaKategori);
            this.tabPage1.Controls.Add(this.cbRestoran);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSiparisiOnayla);
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.dtpIstenenTarih);
            this.tabPage1.Controls.Add(this.lblTutar);
            this.tabPage1.Controls.Add(this.lblFiyat);
            this.tabPage1.Controls.Add(this.btnSepeteEkle);
            this.tabPage1.Controls.Add(this.nAdet);
            this.tabPage1.Controls.Add(this.lstSepet);
            this.tabPage1.Controls.Add(this.lstUrunler);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1192, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SiparisOlustur";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Adres";
            // 
            // lblFirmaPuani
            // 
            this.lblFirmaPuani.AutoSize = true;
            this.lblFirmaPuani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaPuani.Location = new System.Drawing.Point(407, 21);
            this.lblFirmaPuani.Name = "lblFirmaPuani";
            this.lblFirmaPuani.Size = new System.Drawing.Size(90, 16);
            this.lblFirmaPuani.TabIndex = 54;
            this.lblFirmaPuani.Text = "Firma Puanı";
            // 
            // lFirmaPuani
            // 
            this.lFirmaPuani.AutoSize = true;
            this.lFirmaPuani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lFirmaPuani.Location = new System.Drawing.Point(311, 21);
            this.lFirmaPuani.Name = "lFirmaPuani";
            this.lFirmaPuani.Size = new System.Drawing.Size(90, 16);
            this.lFirmaPuani.TabIndex = 54;
            this.lFirmaPuani.Text = "Firma Puanı";
            // 
            // cbOdemeTipi
            // 
            this.cbOdemeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdemeTipi.FormattingEnabled = true;
            this.cbOdemeTipi.Location = new System.Drawing.Point(954, 361);
            this.cbOdemeTipi.Name = "cbOdemeTipi";
            this.cbOdemeTipi.Size = new System.Drawing.Size(121, 33);
            this.cbOdemeTipi.TabIndex = 53;
            this.cbOdemeTipi.SelectedIndexChanged += new System.EventHandler(this.cbOdemeTipi_SelectedIndexChanged);
            // 
            // cbFirmaKategori
            // 
            this.cbFirmaKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirmaKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFirmaKategori.FormattingEnabled = true;
            this.cbFirmaKategori.Location = new System.Drawing.Point(144, 63);
            this.cbFirmaKategori.Name = "cbFirmaKategori";
            this.cbFirmaKategori.Size = new System.Drawing.Size(145, 24);
            this.cbFirmaKategori.TabIndex = 52;
            this.cbFirmaKategori.SelectedIndexChanged += new System.EventHandler(this.cbFirmaKategori_SelectedIndexChanged);
            // 
            // cbRestoran
            // 
            this.cbRestoran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestoran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRestoran.FormattingEnabled = true;
            this.cbRestoran.Location = new System.Drawing.Point(144, 21);
            this.cbRestoran.Name = "cbRestoran";
            this.cbRestoran.Size = new System.Drawing.Size(145, 24);
            this.cbRestoran.TabIndex = 51;
            this.cbRestoran.SelectedIndexChanged += new System.EventHandler(this.cbRestoran_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Firma Kategorileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Restoran Seç";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(812, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Ödeme Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Adet";
            // 
            // btnSiparisiOnayla
            // 
            this.btnSiparisiOnayla.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisiOnayla.Location = new System.Drawing.Point(798, 416);
            this.btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            this.btnSiparisiOnayla.Size = new System.Drawing.Size(277, 115);
            this.btnSiparisiOnayla.TabIndex = 43;
            this.btnSiparisiOnayla.Text = "Siparişi Onayla";
            this.btnSiparisiOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisiOnayla.Click += new System.EventHandler(this.btnSiparisiOnayla_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(796, 144);
            this.txtAdres.MaxLength = 250;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(278, 193);
            this.txtAdres.TabIndex = 42;
            this.txtAdres.Text = "";
            // 
            // dtpIstenenTarih
            // 
            this.dtpIstenenTarih.CustomFormat = "dd.mm.yy   /  HH:mm";
            this.dtpIstenenTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIstenenTarih.Location = new System.Drawing.Point(796, 82);
            this.dtpIstenenTarih.MinDate = new System.DateTime(2017, 7, 27, 0, 0, 0, 0);
            this.dtpIstenenTarih.Name = "dtpIstenenTarih";
            this.dtpIstenenTarih.Size = new System.Drawing.Size(279, 31);
            this.dtpIstenenTarih.TabIndex = 40;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(307, 441);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(51, 20);
            this.lblTutar.TabIndex = 38;
            this.lblTutar.Text = "Tutar";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(307, 413);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(48, 20);
            this.lblFiyat.TabIndex = 39;
            this.lblFiyat.Text = "Fiyat";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(311, 238);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(183, 122);
            this.btnSepeteEkle.TabIndex = 37;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // nAdet
            // 
            this.nAdet.Location = new System.Drawing.Point(314, 168);
            this.nAdet.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAdet.Name = "nAdet";
            this.nAdet.Size = new System.Drawing.Size(183, 31);
            this.nAdet.TabIndex = 36;
            this.nAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 25;
            this.lstSepet.Location = new System.Drawing.Point(516, 85);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(252, 454);
            this.lstSepet.TabIndex = 34;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 25;
            this.lstUrunler.Location = new System.Drawing.Point(10, 93);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(279, 379);
            this.lstUrunler.TabIndex = 33;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::SeferTasiADO.EntityProject.UI.WFA.Properties.Resources.yemeksepeti_com;
            this.tabPage2.Controls.Add(this.btnYenile);
            this.tabPage2.Controls.Add(this.btnPuanVer);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cbPuan);
            this.tabPage2.Controls.Add(this.lstSiparisler);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1192, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SiparisleriGoruntule";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(333, 57);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(189, 49);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Yenile/Listele";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnPuanVer
            // 
            this.btnPuanVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPuanVer.Location = new System.Drawing.Point(675, 503);
            this.btnPuanVer.Name = "btnPuanVer";
            this.btnPuanVer.Size = new System.Drawing.Size(149, 41);
            this.btnPuanVer.TabIndex = 6;
            this.btnPuanVer.Text = "Puan Ver";
            this.btnPuanVer.UseVisualStyleBackColor = true;
            this.btnPuanVer.Click += new System.EventHandler(this.btnPuanVer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(328, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Siparişi Puanla";
            // 
            // cbPuan
            // 
            this.cbPuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuan.FormattingEnabled = true;
            this.cbPuan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbPuan.Location = new System.Drawing.Point(522, 508);
            this.cbPuan.Name = "cbPuan";
            this.cbPuan.Size = new System.Drawing.Size(121, 33);
            this.cbPuan.TabIndex = 3;
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 20;
            this.lstSiparisler.Location = new System.Drawing.Point(333, 138);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(530, 344);
            this.lstSiparisler.TabIndex = 0;
            // 
            // FormKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 638);
            this.Controls.Add(this.SiparisOlustur);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormKullanici";
            this.Text = "FormKullanici";
            this.Load += new System.EventHandler(this.FormKullanici_Load);
            this.SiparisOlustur.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SiparisOlustur;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblFirmaPuani;
        private System.Windows.Forms.Label lFirmaPuani;
        private System.Windows.Forms.ComboBox cbOdemeTipi;
        private System.Windows.Forms.ComboBox cbFirmaKategori;
        private System.Windows.Forms.ComboBox cbRestoran;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiparisiOnayla;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.DateTimePicker dtpIstenenTarih;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.NumericUpDown nAdet;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPuanVer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPuan;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYenile;
    }
}