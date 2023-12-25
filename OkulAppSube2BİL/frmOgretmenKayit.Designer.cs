namespace OkulAppSube2BİL
{
    partial class frmOgretmenKayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tckno = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txtboxSoyad = new System.Windows.Forms.TextBox();
            this.txtboxTCKNO = new System.Windows.Forms.TextBox();
            this.txtboxAd = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tckno);
            this.groupBox1.Controls.Add(this.lbl_soyad);
            this.groupBox1.Controls.Add(this.txtboxSoyad);
            this.groupBox1.Controls.Add(this.txtboxTCKNO);
            this.groupBox1.Controls.Add(this.txtboxAd);
            this.groupBox1.Controls.Add(this.lbl_ad);
            this.groupBox1.Location = new System.Drawing.Point(51, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Bilgileri";
            // 
            // lbl_tckno
            // 
            this.lbl_tckno.AutoSize = true;
            this.lbl_tckno.Location = new System.Drawing.Point(6, 70);
            this.lbl_tckno.Name = "lbl_tckno";
            this.lbl_tckno.Size = new System.Drawing.Size(115, 16);
            this.lbl_tckno.TabIndex = 1;
            this.lbl_tckno.Text = "Öğretmen TCKNO";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(77, 142);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(47, 16);
            this.lbl_soyad.TabIndex = 3;
            this.lbl_soyad.Text = "Soyad";
            // 
            // txtboxSoyad
            // 
            this.txtboxSoyad.Location = new System.Drawing.Point(127, 136);
            this.txtboxSoyad.Name = "txtboxSoyad";
            this.txtboxSoyad.Size = new System.Drawing.Size(139, 22);
            this.txtboxSoyad.TabIndex = 6;
            // 
            // txtboxTCKNO
            // 
            this.txtboxTCKNO.Location = new System.Drawing.Point(127, 67);
            this.txtboxTCKNO.Name = "txtboxTCKNO";
            this.txtboxTCKNO.Size = new System.Drawing.Size(139, 22);
            this.txtboxTCKNO.TabIndex = 4;
            // 
            // txtboxAd
            // 
            this.txtboxAd.Location = new System.Drawing.Point(127, 104);
            this.txtboxAd.Name = "txtboxAd";
            this.txtboxAd.Size = new System.Drawing.Size(139, 22);
            this.txtboxAd.TabIndex = 5;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(97, 110);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(24, 16);
            this.lbl_ad.TabIndex = 2;
            this.lbl_ad.Text = "Ad";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(151, 310);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // frmOgretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgretmenKayit";
            this.Text = "frmOgretmenKayit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tckno;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txtboxSoyad;
        private System.Windows.Forms.TextBox txtboxTCKNO;
        private System.Windows.Forms.TextBox txtboxAd;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Button btn_kaydet;
    }
}