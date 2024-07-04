namespace HastaneYonetimProjesi
{
    partial class frm_HastaGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkUyeol = new System.Windows.Forms.LinkLabel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre";
            // 
            // lnkUyeol
            // 
            this.lnkUyeol.AutoSize = true;
            this.lnkUyeol.Location = new System.Drawing.Point(492, 225);
            this.lnkUyeol.Name = "lnkUyeol";
            this.lnkUyeol.Size = new System.Drawing.Size(62, 22);
            this.lnkUyeol.TabIndex = 3;
            this.lnkUyeol.TabStop = true;
            this.lnkUyeol.Text = "Üye Ol";
            this.lnkUyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUyeol_LinkClicked);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(281, 218);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(183, 29);
            this.txtSifre.TabIndex = 5;
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(281, 271);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(148, 39);
            this.BtnGirisYap.TabIndex = 6;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(281, 147);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(183, 29);
            this.mskTc.TabIndex = 7;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // frm_HastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(769, 412);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lnkUyeol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_HastaGiris";
            this.Text = "Hasta Girişi";
            this.Load += new System.EventHandler(this.frm_HastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkUyeol;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.MaskedTextBox mskTc;
    }
}