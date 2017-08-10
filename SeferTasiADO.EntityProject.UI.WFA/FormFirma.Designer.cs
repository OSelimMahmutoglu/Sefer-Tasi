namespace SeferTasiADO.EntityProject.UI.WFA
{
    partial class FormFirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirma));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstUrunleri = new System.Windows.Forms.ListBox();
            this.btnSiparisOnaySiparisİptal = new System.Windows.Forms.Button();
            this.btnSiparisOnaySiparisOnayla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lstSiparisOnay = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbUrun = new System.Windows.Forms.PictureBox();
            this.cbTum = new System.Windows.Forms.CheckBox();
            this.btnUrunEkleSil = new System.Windows.Forms.Button();
            this.btnUrunEkleGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkleYeni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSatistaMi = new System.Windows.Forms.CheckBox();
            this.txtUrunEKleFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunEkleUrunAdi = new System.Windows.Forms.TextBox();
            this.cmbUrunEkleKategoriler = new System.Windows.Forms.ComboBox();
            this.lstUrunEkleUrunler = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChartOdemeTuru = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartUrunFiyat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOdemeTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartUrunFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(209, 106);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.lstUrunleri);
            this.tabPage1.Controls.Add(this.btnSiparisOnaySiparisİptal);
            this.tabPage1.Controls.Add(this.btnSiparisOnaySiparisOnayla);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.lstSiparisOnay);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(754, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sİpariş Onay";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstUrunleri
            // 
            this.lstUrunleri.Enabled = false;
            this.lstUrunleri.FormattingEnabled = true;
            this.lstUrunleri.ItemHeight = 16;
            this.lstUrunleri.Location = new System.Drawing.Point(530, 135);
            this.lstUrunleri.Name = "lstUrunleri";
            this.lstUrunleri.Size = new System.Drawing.Size(97, 196);
            this.lstUrunleri.TabIndex = 4;
            // 
            // btnSiparisOnaySiparisİptal
            // 
            this.btnSiparisOnaySiparisİptal.Location = new System.Drawing.Point(169, 349);
            this.btnSiparisOnaySiparisİptal.Name = "btnSiparisOnaySiparisİptal";
            this.btnSiparisOnaySiparisİptal.Size = new System.Drawing.Size(114, 36);
            this.btnSiparisOnaySiparisİptal.TabIndex = 3;
            this.btnSiparisOnaySiparisİptal.Text = "Sipariş İptal";
            this.btnSiparisOnaySiparisİptal.UseVisualStyleBackColor = true;
            this.btnSiparisOnaySiparisİptal.Click += new System.EventHandler(this.btnSiparisOnaySiparisİptal_Click);
            // 
            // btnSiparisOnaySiparisOnayla
            // 
            this.btnSiparisOnaySiparisOnayla.Location = new System.Drawing.Point(35, 349);
            this.btnSiparisOnaySiparisOnayla.Name = "btnSiparisOnaySiparisOnayla";
            this.btnSiparisOnaySiparisOnayla.Size = new System.Drawing.Size(110, 36);
            this.btnSiparisOnaySiparisOnayla.TabIndex = 3;
            this.btnSiparisOnaySiparisOnayla.Text = "Sipariş Onayla";
            this.btnSiparisOnaySiparisOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisOnaySiparisOnayla.Click += new System.EventHandler(this.btnSiparisOnaySiparisOnayla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Urunler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teslim Zamanı";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.mm.yy / HH.dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lstSiparisOnay
            // 
            this.lstSiparisOnay.FormattingEnabled = true;
            this.lstSiparisOnay.ItemHeight = 16;
            this.lstSiparisOnay.Location = new System.Drawing.Point(35, 39);
            this.lstSiparisOnay.Name = "lstSiparisOnay";
            this.lstSiparisOnay.Size = new System.Drawing.Size(445, 292);
            this.lstSiparisOnay.TabIndex = 0;
            this.lstSiparisOnay.SelectedIndexChanged += new System.EventHandler(this.lstSiparisOnay_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.pbUrun);
            this.tabPage2.Controls.Add(this.cbTum);
            this.tabPage2.Controls.Add(this.btnUrunEkleSil);
            this.tabPage2.Controls.Add(this.btnUrunEkleGuncelle);
            this.tabPage2.Controls.Add(this.btnUrunEkleYeni);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbSatistaMi);
            this.tabPage2.Controls.Add(this.txtUrunEKleFiyat);
            this.tabPage2.Controls.Add(this.txtUrunEkleUrunAdi);
            this.tabPage2.Controls.Add(this.cmbUrunEkleKategoriler);
            this.tabPage2.Controls.Add(this.lstUrunEkleUrunler);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(754, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürün Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbUrun
            // 
            this.pbUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pbUrun.Location = new System.Drawing.Point(380, 177);
            this.pbUrun.Name = "pbUrun";
            this.pbUrun.Size = new System.Drawing.Size(317, 191);
            this.pbUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrun.TabIndex = 19;
            this.pbUrun.TabStop = false;
            this.pbUrun.Click += new System.EventHandler(this.pbUrun_Click);
            // 
            // cbTum
            // 
            this.cbTum.AutoSize = true;
            this.cbTum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbTum.Location = new System.Drawing.Point(256, 70);
            this.cbTum.Name = "cbTum";
            this.cbTum.Size = new System.Drawing.Size(76, 29);
            this.cbTum.TabIndex = 18;
            this.cbTum.Text = "Tüm";
            this.cbTum.UseVisualStyleBackColor = true;
            this.cbTum.CheckedChanged += new System.EventHandler(this.cbTum_CheckedChanged);
            // 
            // btnUrunEkleSil
            // 
            this.btnUrunEkleSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkleSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUrunEkleSil.Location = new System.Drawing.Point(600, 374);
            this.btnUrunEkleSil.Name = "btnUrunEkleSil";
            this.btnUrunEkleSil.Size = new System.Drawing.Size(99, 42);
            this.btnUrunEkleSil.TabIndex = 15;
            this.btnUrunEkleSil.Text = "Sil";
            this.btnUrunEkleSil.UseVisualStyleBackColor = true;
            this.btnUrunEkleSil.Click += new System.EventHandler(this.btnUrunEkleSil_Click);
            // 
            // btnUrunEkleGuncelle
            // 
            this.btnUrunEkleGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkleGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUrunEkleGuncelle.Location = new System.Drawing.Point(485, 374);
            this.btnUrunEkleGuncelle.Name = "btnUrunEkleGuncelle";
            this.btnUrunEkleGuncelle.Size = new System.Drawing.Size(108, 42);
            this.btnUrunEkleGuncelle.TabIndex = 16;
            this.btnUrunEkleGuncelle.Text = "Güncelle";
            this.btnUrunEkleGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunEkleGuncelle.Click += new System.EventHandler(this.btnUrunEkleGuncelle_Click);
            // 
            // btnUrunEkleYeni
            // 
            this.btnUrunEkleYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkleYeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUrunEkleYeni.Location = new System.Drawing.Point(380, 374);
            this.btnUrunEkleYeni.Name = "btnUrunEkleYeni";
            this.btnUrunEkleYeni.Size = new System.Drawing.Size(99, 42);
            this.btnUrunEkleYeni.TabIndex = 17;
            this.btnUrunEkleYeni.Text = "Yeni";
            this.btnUrunEkleYeni.UseVisualStyleBackColor = true;
            this.btnUrunEkleYeni.Click += new System.EventHandler(this.btnUrunEkleYeni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(375, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(375, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ürün Adı";
            // 
            // cbSatistaMi
            // 
            this.cbSatistaMi.AutoSize = true;
            this.cbSatistaMi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSatistaMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSatistaMi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbSatistaMi.Location = new System.Drawing.Point(378, 142);
            this.cbSatistaMi.Name = "cbSatistaMi";
            this.cbSatistaMi.Size = new System.Drawing.Size(149, 29);
            this.cbSatistaMi.TabIndex = 11;
            this.cbSatistaMi.Text = "Satışta Mı?";
            this.cbSatistaMi.UseVisualStyleBackColor = true;
            // 
            // txtUrunEKleFiyat
            // 
            this.txtUrunEKleFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunEKleFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtUrunEKleFiyat.Location = new System.Drawing.Point(510, 106);
            this.txtUrunEKleFiyat.Name = "txtUrunEKleFiyat";
            this.txtUrunEKleFiyat.Size = new System.Drawing.Size(187, 31);
            this.txtUrunEKleFiyat.TabIndex = 10;
            // 
            // txtUrunEkleUrunAdi
            // 
            this.txtUrunEkleUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunEkleUrunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtUrunEkleUrunAdi.Location = new System.Drawing.Point(510, 67);
            this.txtUrunEkleUrunAdi.Name = "txtUrunEkleUrunAdi";
            this.txtUrunEkleUrunAdi.Size = new System.Drawing.Size(187, 31);
            this.txtUrunEkleUrunAdi.TabIndex = 10;
            // 
            // cmbUrunEkleKategoriler
            // 
            this.cmbUrunEkleKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunEkleKategoriler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbUrunEkleKategoriler.FormattingEnabled = true;
            this.cmbUrunEkleKategoriler.Location = new System.Drawing.Point(89, 70);
            this.cmbUrunEkleKategoriler.Name = "cmbUrunEkleKategoriler";
            this.cmbUrunEkleKategoriler.Size = new System.Drawing.Size(161, 33);
            this.cmbUrunEkleKategoriler.TabIndex = 9;
            this.cmbUrunEkleKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbUrunEkleKategoriler_SelectedIndexChanged);
            // 
            // lstUrunEkleUrunler
            // 
            this.lstUrunEkleUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunEkleUrunler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lstUrunEkleUrunler.FormattingEnabled = true;
            this.lstUrunEkleUrunler.ItemHeight = 25;
            this.lstUrunEkleUrunler.Location = new System.Drawing.Point(92, 106);
            this.lstUrunEkleUrunler.Name = "lstUrunEkleUrunler";
            this.lstUrunEkleUrunler.Size = new System.Drawing.Size(240, 304);
            this.lstUrunEkleUrunler.TabIndex = 8;
            this.lstUrunEkleUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunEkleUrunler_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.ChartOdemeTuru);
            this.tabPage3.Controls.Add(this.ChartUrunFiyat);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(754, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "İstatistikler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(374, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sipariş-Fiyat İstatistiği";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün-Fiyat İstatistiği";
            // 
            // ChartOdemeTuru
            // 
            this.ChartOdemeTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ChartOdemeTuru.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.ChartOdemeTuru.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.ChartOdemeTuru.BorderlineWidth = 3;
            chartArea3.Name = "Ürünler";
            this.ChartOdemeTuru.ChartAreas.Add(chartArea3);
            legend3.AutoFitMinFontSize = 10;
            legend3.Name = "Legend1";
            this.ChartOdemeTuru.Legends.Add(legend3);
            this.ChartOdemeTuru.Location = new System.Drawing.Point(379, 55);
            this.ChartOdemeTuru.Name = "ChartOdemeTuru";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series3.ChartArea = "Ürünler";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Color = System.Drawing.Color.Red;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series3.Legend = "Legend1";
            series3.Name = "siparisId";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.ChartOdemeTuru.Series.Add(series3);
            this.ChartOdemeTuru.Size = new System.Drawing.Size(375, 319);
            this.ChartOdemeTuru.TabIndex = 0;
            this.ChartOdemeTuru.Text = "İstatistikler";
            title3.Name = "Title1";
            title3.Text = "Sipariş Fiyat İstatistiği";
            this.ChartOdemeTuru.Titles.Add(title3);
            // 
            // ChartUrunFiyat
            // 
            this.ChartUrunFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ChartUrunFiyat.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.ChartUrunFiyat.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.ChartUrunFiyat.BorderlineWidth = 3;
            chartArea4.Name = "Ürünler";
            this.ChartUrunFiyat.ChartAreas.Add(chartArea4);
            legend4.AutoFitMinFontSize = 10;
            legend4.Name = "Legend1";
            this.ChartUrunFiyat.Legends.Add(legend4);
            this.ChartUrunFiyat.Location = new System.Drawing.Point(3, 55);
            this.ChartUrunFiyat.Name = "ChartUrunFiyat";
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series4.ChartArea = "Ürünler";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Color = System.Drawing.Color.Red;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series4.Legend = "Legend1";
            series4.Name = "UrunFiyat";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.ChartUrunFiyat.Series.Add(series4);
            this.ChartUrunFiyat.Size = new System.Drawing.Size(375, 319);
            this.ChartUrunFiyat.TabIndex = 0;
            this.ChartUrunFiyat.Text = "İstatistikler";
            title4.Name = "Title1";
            title4.Text = "Ürün Fiyat İstatistiği";
            this.ChartUrunFiyat.Titles.Add(title4);
            // 
            // DosyaAc
            // 
            this.DosyaAc.FileName = "openFileDialog1";
            // 
            // FormFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 626);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormFirma";
            this.Text = "FormFirma";
            this.Load += new System.EventHandler(this.FormFirma_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOdemeTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartUrunFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSiparisOnaySiparisİptal;
        private System.Windows.Forms.Button btnSiparisOnaySiparisOnayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lstSiparisOnay;
        private System.Windows.Forms.CheckBox cbTum;
        private System.Windows.Forms.Button btnUrunEkleSil;
        private System.Windows.Forms.Button btnUrunEkleGuncelle;
        private System.Windows.Forms.Button btnUrunEkleYeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbSatistaMi;
        private System.Windows.Forms.TextBox txtUrunEkleUrunAdi;
        private System.Windows.Forms.ComboBox cmbUrunEkleKategoriler;
        private System.Windows.Forms.ListBox lstUrunEkleUrunler;
        private System.Windows.Forms.PictureBox pbUrun;
        private System.Windows.Forms.OpenFileDialog DosyaAc;
        private System.Windows.Forms.TextBox txtUrunEKleFiyat;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartUrunFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartOdemeTuru;
        private System.Windows.Forms.ListBox lstUrunleri;
        private System.Windows.Forms.Label label6;
    }
}