namespace OkulAppSube2BİL
{
    partial class frmOgrKayit
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
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Numara = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.lbl_numara = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.grp_Ogrenci = new System.Windows.Forms.GroupBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grp_Ogrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(100, 108);
            this.txt_Soyad.MaxLength = 30;
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(124, 22);
            this.txt_Soyad.TabIndex = 0;
            // 
            // txt_Numara
            // 
            this.txt_Numara.Location = new System.Drawing.Point(100, 150);
            this.txt_Numara.MaxLength = 15;
            this.txt_Numara.Name = "txt_Numara";
            this.txt_Numara.Size = new System.Drawing.Size(124, 22);
            this.txt_Numara.TabIndex = 1;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(100, 65);
            this.txt_Ad.MaxLength = 20;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(124, 22);
            this.txt_Ad.TabIndex = 2;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(112, 273);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 34);
            this.btn_Kaydet.TabIndex = 3;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(49, 71);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(24, 16);
            this.lbl_Ad.TabIndex = 4;
            this.lbl_Ad.Text = "Ad";
            // 
            // lbl_numara
            // 
            this.lbl_numara.AutoSize = true;
            this.lbl_numara.Location = new System.Drawing.Point(22, 156);
            this.lbl_numara.Name = "lbl_numara";
            this.lbl_numara.Size = new System.Drawing.Size(55, 16);
            this.lbl_numara.TabIndex = 5;
            this.lbl_numara.Text = "Numara";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(28, 114);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(47, 16);
            this.lbl_soyad.TabIndex = 6;
            this.lbl_soyad.Text = "Soyad";
            // 
            // grp_Ogrenci
            // 
            this.grp_Ogrenci.Controls.Add(this.txt_Ad);
            this.grp_Ogrenci.Controls.Add(this.lbl_numara);
            this.grp_Ogrenci.Controls.Add(this.lbl_soyad);
            this.grp_Ogrenci.Controls.Add(this.txt_Soyad);
            this.grp_Ogrenci.Controls.Add(this.txt_Numara);
            this.grp_Ogrenci.Controls.Add(this.lbl_Ad);
            this.grp_Ogrenci.Location = new System.Drawing.Point(12, 34);
            this.grp_Ogrenci.Name = "grp_Ogrenci";
            this.grp_Ogrenci.Size = new System.Drawing.Size(254, 233);
            this.grp_Ogrenci.TabIndex = 7;
            this.grp_Ogrenci.TabStop = false;
            this.grp_Ogrenci.Text = "Öğrenci Bilgileri";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(299, 99);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(96, 34);
            this.btnBul.TabIndex = 8;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(299, 142);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 34);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(299, 184);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(96, 35);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 421);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.grp_Ogrenci);
            this.Controls.Add(this.btn_Kaydet);
            this.Name = "frmOgrKayit";
            this.Text = "Öğrenci Kayıt İşlemleri";
            this.grp_Ogrenci.ResumeLayout(false);
            this.grp_Ogrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label lbl_numara;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.GroupBox grp_Ogrenci;
        public System.Windows.Forms.TextBox txt_Soyad;
        public System.Windows.Forms.TextBox txt_Numara;
        public System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

