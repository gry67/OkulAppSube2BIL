namespace OkulAppSube2BİL
{
    partial class frmOgrBul
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
            this.grpbxBul = new System.Windows.Forms.GroupBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.grpbxBul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxBul
            // 
            this.grpbxBul.Controls.Add(this.btnBul);
            this.grpbxBul.Controls.Add(this.txtNumara);
            this.grpbxBul.Controls.Add(this.lblNumara);
            this.grpbxBul.Location = new System.Drawing.Point(37, 28);
            this.grpbxBul.Name = "grpbxBul";
            this.grpbxBul.Size = new System.Drawing.Size(324, 169);
            this.grpbxBul.TabIndex = 0;
            this.grpbxBul.TabStop = false;
            this.grpbxBul.Text = "Öğrenci Bulma Ekranı";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(76, 54);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(154, 16);
            this.lblNumara.TabIndex = 0;
            this.lblNumara.Text = "Öğrenci Numarası Giriniz";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(79, 86);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(138, 22);
            this.txtNumara.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(104, 114);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // frmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 233);
            this.Controls.Add(this.grpbxBul);
            this.Name = "frmOgrBul";
            this.Text = "frmOgrBul";
            this.grpbxBul.ResumeLayout(false);
            this.grpbxBul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label lblNumara;
    }
}