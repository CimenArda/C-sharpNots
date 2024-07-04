namespace HastaneYonetimProjesi
{
    partial class frm_DoktorBilgiDüzenle
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
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(243, 111);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(167, 28);
            this.txtSoyad.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(243, 53);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(167, 28);
            this.txtAd.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ad";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(243, 159);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(167, 28);
            this.mskTc.TabIndex = 37;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "TC Kimlik No";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(243, 279);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(167, 28);
            this.txtSifre.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Şifre";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(243, 224);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(167, 29);
            this.cmbBrans.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Branş";
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(243, 326);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(136, 39);
            this.btnBilgiGuncelle.TabIndex = 42;
            this.btnBilgiGuncelle.Text = "Bilgi Güncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = true;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click);
            // 
            // frm_DoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(531, 520);
            this.Controls.Add(this.btnBilgiGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DoktorBilgiDüzenle";
            this.Text = "frm_DoktorBilgiDüzenle";
            this.Load += new System.EventHandler(this.frm_DoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBilgiGuncelle;
    }
}