namespace OkulAppSube2BİL
{
    partial class frmSecim
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
            this.lbl_secimSoru = new System.Windows.Forms.Label();
            this.btn_ogrenciSec = new System.Windows.Forms.Button();
            this.btn_ogretmenSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_secimSoru
            // 
            this.lbl_secimSoru.AutoSize = true;
            this.lbl_secimSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_secimSoru.Location = new System.Drawing.Point(210, 119);
            this.lbl_secimSoru.Name = "lbl_secimSoru";
            this.lbl_secimSoru.Size = new System.Drawing.Size(352, 29);
            this.lbl_secimSoru.TabIndex = 0;
            this.lbl_secimSoru.Text = "Hangisini Eklemek İstersiniz ?";
            // 
            // btn_ogrenciSec
            // 
            this.btn_ogrenciSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ogrenciSec.Location = new System.Drawing.Point(224, 169);
            this.btn_ogrenciSec.Name = "btn_ogrenciSec";
            this.btn_ogrenciSec.Size = new System.Drawing.Size(151, 86);
            this.btn_ogrenciSec.TabIndex = 1;
            this.btn_ogrenciSec.Text = "Öğrenci İşlemleri";
            this.btn_ogrenciSec.UseVisualStyleBackColor = true;
            this.btn_ogrenciSec.Click += new System.EventHandler(this.btn_ogrenciSec_Click);
            // 
            // btn_ogretmenSec
            // 
            this.btn_ogretmenSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ogretmenSec.Location = new System.Drawing.Point(381, 169);
            this.btn_ogretmenSec.Name = "btn_ogretmenSec";
            this.btn_ogretmenSec.Size = new System.Drawing.Size(151, 86);
            this.btn_ogretmenSec.TabIndex = 2;
            this.btn_ogretmenSec.Text = "Öğretmen Ekle";
            this.btn_ogretmenSec.UseVisualStyleBackColor = true;
            this.btn_ogretmenSec.Click += new System.EventHandler(this.btn_ogretmenSec_Click);
            // 
            // frmSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.btn_ogretmenSec);
            this.Controls.Add(this.btn_ogrenciSec);
            this.Controls.Add(this.lbl_secimSoru);
            this.Name = "frmSecim";
            this.Text = "frmSecim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_secimSoru;
        private System.Windows.Forms.Button btn_ogrenciSec;
        private System.Windows.Forms.Button btn_ogretmenSec;
    }
}