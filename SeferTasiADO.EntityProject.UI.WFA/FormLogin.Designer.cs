namespace SeferTasiADO.EntityProject.UI.WFA
{
    partial class FormLogin
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
            this.tcFormLogin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.llKayitOl = new System.Windows.Forms.LinkLabel();
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tcFormLogin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcFormLogin
            // 
            this.tcFormLogin.Controls.Add(this.tabPage1);
            this.tcFormLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcFormLogin.Location = new System.Drawing.Point(69, 30);
            this.tcFormLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tcFormLogin.Name = "tcFormLogin";
            this.tcFormLogin.SelectedIndex = 0;
            this.tcFormLogin.Size = new System.Drawing.Size(825, 522);
            this.tcFormLogin.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcFormLogin.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.BackgroundImage = global::SeferTasiADO.EntityProject.UI.WFA.Properties.Resources.yemeksepeti_com;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.llKayitOl);
            this.tabPage1.Controls.Add(this.btnKullaniciGiris);
            this.tabPage1.Controls.Add(this.txtKullaniciSifre);
            this.tabPage1.Controls.Add(this.txtKullaniciAdi);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(817, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kullanıcı Girişi";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // llKayitOl
            // 
            this.llKayitOl.AutoSize = true;
            this.llKayitOl.Location = new System.Drawing.Point(117, 230);
            this.llKayitOl.Name = "llKayitOl";
            this.llKayitOl.Size = new System.Drawing.Size(95, 25);
            this.llKayitOl.TabIndex = 2;
            this.llKayitOl.TabStop = true;
            this.llKayitOl.Text = "Kayıt Ol";
            this.llKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llKayitOl_LinkClicked);
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKullaniciGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKullaniciGiris.Location = new System.Drawing.Point(109, 164);
            this.btnKullaniciGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(173, 47);
            this.btnKullaniciGiris.TabIndex = 1;
            this.btnKullaniciGiris.Text = "Giriş Yap";
            this.btnKullaniciGiris.UseVisualStyleBackColor = false;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSifre.Location = new System.Drawing.Point(109, 110);
            this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(213, 20);
            this.txtKullaniciSifre.TabIndex = 0;
            this.txtKullaniciSifre.Text = "123";
            this.txtKullaniciSifre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKullaniciSifre_MouseClick);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(109, 55);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(213, 31);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.Text = "Tasabi2";
            this.txtKullaniciAdi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKullaniciAdi_MouseClick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 613);
            this.Controls.Add(this.tcFormLogin);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Enter += new System.EventHandler(this.btnKullaniciGiris_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormLogin_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyUp);
            this.tcFormLogin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcFormLogin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.LinkLabel llKayitOl;
    }
}

