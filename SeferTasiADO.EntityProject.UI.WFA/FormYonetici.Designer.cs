namespace SeferTasiADO.EntityProject.UI.WFA
{
    partial class FormYonetici
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbTumMusteriler = new System.Windows.Forms.CheckBox();
            this.cbTumFirmalar = new System.Windows.Forms.CheckBox();
            this.btnKullaniciyiPasifYap = new System.Windows.Forms.Button();
            this.btnFirmayiPasifYap = new System.Windows.Forms.Button();
            this.btnKullaniciyiAktifEt = new System.Windows.Forms.Button();
            this.btnFirmaAktifEt = new System.Windows.Forms.Button();
            this.lstKullaniciler = new System.Windows.Forms.ListBox();
            this.lstFirmalar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Firmalar = new System.Windows.Forms.Label();
            this.lstSeciliKullanici = new System.Windows.Forms.ListBox();
            this.lstSeciliFirma = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnKullaniciOlusturKayitOl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKullaniciOlusturAdres = new System.Windows.Forms.TextBox();
            this.txtKullaniciOlusturMail = new System.Windows.Forms.TextBox();
            this.txtKullaniciOlusturTel = new System.Windows.Forms.TextBox();
            this.txtKullaniciOlusturParolaOnay = new System.Windows.Forms.TextBox();
            this.txtKullaniciOlusturParola = new System.Windows.Forms.TextBox();
            this.txtKullaniciOlusturSoyisim = new System.Windows.Forms.TextBox();
            this.txtKullaniciOlusturKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKullaniciOlusturIsim = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvFirmaHareketleri = new System.Windows.Forms.DataGridView();
            this.cmbFirmalar = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmaHareketleri)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbTumMusteriler);
            this.tabPage1.Controls.Add(this.cbTumFirmalar);
            this.tabPage1.Controls.Add(this.btnKullaniciyiPasifYap);
            this.tabPage1.Controls.Add(this.btnFirmayiPasifYap);
            this.tabPage1.Controls.Add(this.btnKullaniciyiAktifEt);
            this.tabPage1.Controls.Add(this.btnFirmaAktifEt);
            this.tabPage1.Controls.Add(this.lstKullaniciler);
            this.tabPage1.Controls.Add(this.lstFirmalar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Firmalar);
            this.tabPage1.Controls.Add(this.lstSeciliKullanici);
            this.tabPage1.Controls.Add(this.lstSeciliFirma);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kullanıcı Onayları";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cbTumMusteriler
            // 
            this.cbTumMusteriler.AutoSize = true;
            this.cbTumMusteriler.Checked = true;
            this.cbTumMusteriler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTumMusteriler.Location = new System.Drawing.Point(481, 20);
            this.cbTumMusteriler.Name = "cbTumMusteriler";
            this.cbTumMusteriler.Size = new System.Drawing.Size(95, 17);
            this.cbTumMusteriler.TabIndex = 7;
            this.cbTumMusteriler.Text = "Tüm Müşteriler";
            this.cbTumMusteriler.UseVisualStyleBackColor = true;
            this.cbTumMusteriler.CheckedChanged += new System.EventHandler(this.cbTumMusteriler_CheckedChanged);
            // 
            // cbTumFirmalar
            // 
            this.cbTumFirmalar.AutoSize = true;
            this.cbTumFirmalar.Checked = true;
            this.cbTumFirmalar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTumFirmalar.Location = new System.Drawing.Point(83, 20);
            this.cbTumFirmalar.Name = "cbTumFirmalar";
            this.cbTumFirmalar.Size = new System.Drawing.Size(83, 17);
            this.cbTumFirmalar.TabIndex = 6;
            this.cbTumFirmalar.Text = "TumFirmalar";
            this.cbTumFirmalar.UseVisualStyleBackColor = true;
            this.cbTumFirmalar.CheckedChanged += new System.EventHandler(this.cbTumFirmalar_CheckedChanged);
            // 
            // btnKullaniciyiPasifYap
            // 
            this.btnKullaniciyiPasifYap.Location = new System.Drawing.Point(391, 377);
            this.btnKullaniciyiPasifYap.Name = "btnKullaniciyiPasifYap";
            this.btnKullaniciyiPasifYap.Size = new System.Drawing.Size(159, 23);
            this.btnKullaniciyiPasifYap.TabIndex = 5;
            this.btnKullaniciyiPasifYap.Text = "Secili Kullanıcıyı Pasif Yap";
            this.btnKullaniciyiPasifYap.UseVisualStyleBackColor = true;
            this.btnKullaniciyiPasifYap.Click += new System.EventHandler(this.btnKullaniciyiPasifYap_Click);
            // 
            // btnFirmayiPasifYap
            // 
            this.btnFirmayiPasifYap.Location = new System.Drawing.Point(27, 377);
            this.btnFirmayiPasifYap.Name = "btnFirmayiPasifYap";
            this.btnFirmayiPasifYap.Size = new System.Drawing.Size(159, 23);
            this.btnFirmayiPasifYap.TabIndex = 5;
            this.btnFirmayiPasifYap.Text = "Secili Firmayı Pasif Yap";
            this.btnFirmayiPasifYap.UseVisualStyleBackColor = true;
            this.btnFirmayiPasifYap.Click += new System.EventHandler(this.btnFirmayiPasifYap_Click);
            // 
            // btnKullaniciyiAktifEt
            // 
            this.btnKullaniciyiAktifEt.Location = new System.Drawing.Point(391, 348);
            this.btnKullaniciyiAktifEt.Name = "btnKullaniciyiAktifEt";
            this.btnKullaniciyiAktifEt.Size = new System.Drawing.Size(159, 23);
            this.btnKullaniciyiAktifEt.TabIndex = 5;
            this.btnKullaniciyiAktifEt.Text = "Secili Kullanıcıyı Aktif Yap";
            this.btnKullaniciyiAktifEt.UseVisualStyleBackColor = true;
            this.btnKullaniciyiAktifEt.Click += new System.EventHandler(this.btnKullaniciyiAktifEt_Click);
            // 
            // btnFirmaAktifEt
            // 
            this.btnFirmaAktifEt.Location = new System.Drawing.Point(27, 348);
            this.btnFirmaAktifEt.Name = "btnFirmaAktifEt";
            this.btnFirmaAktifEt.Size = new System.Drawing.Size(159, 23);
            this.btnFirmaAktifEt.TabIndex = 5;
            this.btnFirmaAktifEt.Text = "Secili Firmayı Aktif Et";
            this.btnFirmaAktifEt.UseVisualStyleBackColor = true;
            this.btnFirmaAktifEt.Click += new System.EventHandler(this.btnFirmaAktifEt_Click);
            // 
            // lstKullaniciler
            // 
            this.lstKullaniciler.FormattingEnabled = true;
            this.lstKullaniciler.Location = new System.Drawing.Point(391, 39);
            this.lstKullaniciler.Name = "lstKullaniciler";
            this.lstKullaniciler.Size = new System.Drawing.Size(159, 303);
            this.lstKullaniciler.TabIndex = 4;
            this.lstKullaniciler.SelectedIndexChanged += new System.EventHandler(this.lstKullaniciler_SelectedIndexChanged);
            // 
            // lstFirmalar
            // 
            this.lstFirmalar.FormattingEnabled = true;
            this.lstFirmalar.Location = new System.Drawing.Point(27, 39);
            this.lstFirmalar.Name = "lstFirmalar";
            this.lstFirmalar.Size = new System.Drawing.Size(159, 303);
            this.lstFirmalar.TabIndex = 3;
            this.lstFirmalar.SelectedIndexChanged += new System.EventHandler(this.lstFirmalar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanicilar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Detay";
            this.label3.Click += new System.EventHandler(this.Firmalar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firma Detay";
            this.label2.Click += new System.EventHandler(this.Firmalar_Click);
            // 
            // Firmalar
            // 
            this.Firmalar.AutoSize = true;
            this.Firmalar.Location = new System.Drawing.Point(24, 20);
            this.Firmalar.Name = "Firmalar";
            this.Firmalar.Size = new System.Drawing.Size(43, 13);
            this.Firmalar.TabIndex = 2;
            this.Firmalar.Text = "Firmalar";
            this.Firmalar.Click += new System.EventHandler(this.Firmalar_Click);
            // 
            // lstSeciliKullanici
            // 
            this.lstSeciliKullanici.Enabled = false;
            this.lstSeciliKullanici.FormattingEnabled = true;
            this.lstSeciliKullanici.Location = new System.Drawing.Point(593, 39);
            this.lstSeciliKullanici.Name = "lstSeciliKullanici";
            this.lstSeciliKullanici.Size = new System.Drawing.Size(157, 303);
            this.lstSeciliKullanici.TabIndex = 1;
            // 
            // lstSeciliFirma
            // 
            this.lstSeciliFirma.Enabled = false;
            this.lstSeciliFirma.FormattingEnabled = true;
            this.lstSeciliFirma.Location = new System.Drawing.Point(216, 39);
            this.lstSeciliFirma.Name = "lstSeciliFirma";
            this.lstSeciliFirma.Size = new System.Drawing.Size(157, 303);
            this.lstSeciliFirma.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnKullaniciOlusturKayitOl);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtKullaniciOlusturAdres);
            this.tabPage2.Controls.Add(this.txtKullaniciOlusturMail);
            this.tabPage2.Controls.Add(this.txtKullaniciOlusturTel);
            this.tabPage2.Controls.Add(this.txtKullaniciOlusturParolaOnay);
            this.tabPage2.Controls.Add(this.txtKullaniciOlusturParola);
            this.tabPage2.Controls.Add(this.txtKullaniciOlusturSoyisim);
            this.tabPage2.Controls.Add(this.txtKullaniciOlusturKullaniciAdi);
            this.tabPage2.Controls.Add(this.txtKullaniciOlusturIsim);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yönetici Ekleme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciOlusturKayitOl
            // 
            this.btnKullaniciOlusturKayitOl.BackColor = System.Drawing.Color.Lime;
            this.btnKullaniciOlusturKayitOl.ForeColor = System.Drawing.Color.Black;
            this.btnKullaniciOlusturKayitOl.Location = new System.Drawing.Point(160, 286);
            this.btnKullaniciOlusturKayitOl.Name = "btnKullaniciOlusturKayitOl";
            this.btnKullaniciOlusturKayitOl.Size = new System.Drawing.Size(308, 30);
            this.btnKullaniciOlusturKayitOl.TabIndex = 19;
            this.btnKullaniciOlusturKayitOl.Text = "Kayıt Ol";
            this.btnKullaniciOlusturKayitOl.UseVisualStyleBackColor = false;
            this.btnKullaniciOlusturKayitOl.Click += new System.EventHandler(this.btnKullaniciOlusturKayitOl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(399, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(157, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Soyisim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(157, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(397, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Parola Tekrar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(399, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Parola";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(397, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(157, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(157, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "İsim";
            // 
            // txtKullaniciOlusturAdres
            // 
            this.txtKullaniciOlusturAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciOlusturAdres.Location = new System.Drawing.Point(481, 236);
            this.txtKullaniciOlusturAdres.Multiline = true;
            this.txtKullaniciOlusturAdres.Name = "txtKullaniciOlusturAdres";
            this.txtKullaniciOlusturAdres.Size = new System.Drawing.Size(144, 80);
            this.txtKullaniciOlusturAdres.TabIndex = 9;
            // 
            // txtKullaniciOlusturMail
            // 
            this.txtKullaniciOlusturMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciOlusturMail.Location = new System.Drawing.Point(239, 180);
            this.txtKullaniciOlusturMail.Name = "txtKullaniciOlusturMail";
            this.txtKullaniciOlusturMail.Size = new System.Drawing.Size(144, 22);
            this.txtKullaniciOlusturMail.TabIndex = 8;
            // 
            // txtKullaniciOlusturTel
            // 
            this.txtKullaniciOlusturTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciOlusturTel.Location = new System.Drawing.Point(239, 226);
            this.txtKullaniciOlusturTel.Name = "txtKullaniciOlusturTel";
            this.txtKullaniciOlusturTel.Size = new System.Drawing.Size(144, 22);
            this.txtKullaniciOlusturTel.TabIndex = 7;
            // 
            // txtKullaniciOlusturParolaOnay
            // 
            this.txtKullaniciOlusturParolaOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciOlusturParolaOnay.Location = new System.Drawing.Point(481, 178);
            this.txtKullaniciOlusturParolaOnay.Name = "txtKullaniciOlusturParolaOnay";
            this.txtKullaniciOlusturParolaOnay.Size = new System.Drawing.Size(123, 22);
            this.txtKullaniciOlusturParolaOnay.TabIndex = 6;
            // 
            // txtKullaniciOlusturParola
            // 
            this.txtKullaniciOlusturParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciOlusturParola.Location = new System.Drawing.Point(481, 134);
            this.txtKullaniciOlusturParola.Name = "txtKullaniciOlusturParola";
            this.txtKullaniciOlusturParola.Size = new System.Drawing.Size(123, 22);
            this.txtKullaniciOlusturParola.TabIndex = 5;
            // 
            // txtKullaniciOlusturSoyisim
            // 
            this.txtKullaniciOlusturSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciOlusturSoyisim.Location = new System.Drawing.Point(239, 134);
            this.txtKullaniciOlusturSoyisim.Name = "txtKullaniciOlusturSoyisim";
            this.txtKullaniciOlusturSoyisim.Size = new System.Drawing.Size(144, 22);
            this.txtKullaniciOlusturSoyisim.TabIndex = 4;
            // 
            // txtKullaniciOlusturKullaniciAdi
            // 
            this.txtKullaniciOlusturKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciOlusturKullaniciAdi.Location = new System.Drawing.Point(481, 85);
            this.txtKullaniciOlusturKullaniciAdi.Name = "txtKullaniciOlusturKullaniciAdi";
            this.txtKullaniciOlusturKullaniciAdi.Size = new System.Drawing.Size(123, 22);
            this.txtKullaniciOlusturKullaniciAdi.TabIndex = 10;
            // 
            // txtKullaniciOlusturIsim
            // 
            this.txtKullaniciOlusturIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciOlusturIsim.Location = new System.Drawing.Point(239, 88);
            this.txtKullaniciOlusturIsim.Name = "txtKullaniciOlusturIsim";
            this.txtKullaniciOlusturIsim.Size = new System.Drawing.Size(144, 22);
            this.txtKullaniciOlusturIsim.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbFirmalar);
            this.tabPage3.Controls.Add(this.dgvFirmaHareketleri);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(769, 462);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "İstatistikler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvFirmaHareketleri
            // 
            this.dgvFirmaHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirmaHareketleri.Location = new System.Drawing.Point(2, 51);
            this.dgvFirmaHareketleri.Name = "dgvFirmaHareketleri";
            this.dgvFirmaHareketleri.Size = new System.Drawing.Size(757, 406);
            this.dgvFirmaHareketleri.TabIndex = 4;
            // 
            // cmbFirmalar
            // 
            this.cmbFirmalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFirmalar.FormattingEnabled = true;
            this.cmbFirmalar.Location = new System.Drawing.Point(11, 16);
            this.cmbFirmalar.Name = "cmbFirmalar";
            this.cmbFirmalar.Size = new System.Drawing.Size(91, 21);
            this.cmbFirmalar.TabIndex = 5;
            this.cmbFirmalar.SelectedIndexChanged += new System.EventHandler(this.cmbFirmalar_SelectedIndexChanged);
            // 
            // FormYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 486);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormYonetici";
            this.Text = "FormYonetici";
            this.Load += new System.EventHandler(this.FormYonetici_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmaHareketleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Firmalar;
        private System.Windows.Forms.ListBox lstSeciliKullanici;
        private System.Windows.Forms.ListBox lstSeciliFirma;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKullaniciOlusturKayitOl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKullaniciOlusturAdres;
        private System.Windows.Forms.TextBox txtKullaniciOlusturMail;
        private System.Windows.Forms.TextBox txtKullaniciOlusturTel;
        private System.Windows.Forms.TextBox txtKullaniciOlusturParolaOnay;
        private System.Windows.Forms.TextBox txtKullaniciOlusturParola;
        private System.Windows.Forms.TextBox txtKullaniciOlusturSoyisim;
        private System.Windows.Forms.TextBox txtKullaniciOlusturKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciOlusturIsim;
        private System.Windows.Forms.CheckBox cbTumMusteriler;
        private System.Windows.Forms.CheckBox cbTumFirmalar;
        private System.Windows.Forms.Button btnKullaniciyiPasifYap;
        private System.Windows.Forms.Button btnFirmayiPasifYap;
        private System.Windows.Forms.Button btnKullaniciyiAktifEt;
        private System.Windows.Forms.Button btnFirmaAktifEt;
        private System.Windows.Forms.ListBox lstKullaniciler;
        private System.Windows.Forms.ListBox lstFirmalar;
        private System.Windows.Forms.DataGridView dgvFirmaHareketleri;
        private System.Windows.Forms.ComboBox cmbFirmalar;
    }
}