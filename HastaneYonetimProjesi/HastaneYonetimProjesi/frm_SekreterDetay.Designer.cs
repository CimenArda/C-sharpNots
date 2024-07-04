namespace HastaneYonetimProjesi
{
    partial class frm_SekreterDetay
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
            this.LblSekreterAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSekreterTcNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.txtDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.txtSekreterId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRandevuListesi = new System.Windows.Forms.Button();
            this.btnBransPanel = new System.Windows.Forms.Button();
            this.btnDoktorPanel = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblSekreterAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSekreterTcNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgileri";
            // 
            // LblSekreterAdSoyad
            // 
            this.LblSekreterAdSoyad.AutoSize = true;
            this.LblSekreterAdSoyad.Location = new System.Drawing.Point(186, 119);
            this.LblSekreterAdSoyad.Name = "LblSekreterAdSoyad";
            this.LblSekreterAdSoyad.Size = new System.Drawing.Size(46, 24);
            this.LblSekreterAdSoyad.TabIndex = 3;
            this.LblSekreterAdSoyad.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı Soyadı:";
            // 
            // lblSekreterTcNo
            // 
            this.lblSekreterTcNo.AutoSize = true;
            this.lblSekreterTcNo.Location = new System.Drawing.Point(186, 72);
            this.lblSekreterTcNo.Name = "lblSekreterTcNo";
            this.lblSekreterTcNo.Size = new System.Drawing.Size(120, 24);
            this.lblSekreterTcNo.TabIndex = 1;
            this.lblSekreterTcNo.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOlustur);
            this.groupBox2.Controls.Add(this.txtDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 264);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(76, 213);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(230, 34);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // txtDuyuru
            // 
            this.txtDuyuru.Location = new System.Drawing.Point(54, 31);
            this.txtDuyuru.Name = "txtDuyuru";
            this.txtDuyuru.Size = new System.Drawing.Size(295, 176);
            this.txtDuyuru.TabIndex = 0;
            this.txtDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.chkDurum);
            this.groupBox3.Controls.Add(this.mskTC);
            this.groupBox3.Controls.Add(this.cmbDoktor);
            this.groupBox3.Controls.Add(this.cmbBrans);
            this.groupBox3.Controls.Add(this.msksaat);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.msktarih);
            this.groupBox3.Controls.Add(this.txtSekreterId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(455, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 496);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(115, 392);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(190, 34);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet ";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Location = new System.Drawing.Point(140, 358);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(92, 28);
            this.chkDurum.TabIndex = 11;
            this.chkDurum.Text = "Durum";
            this.chkDurum.UseVisualStyleBackColor = true;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(140, 311);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(180, 32);
            this.mskTC.TabIndex = 10;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(140, 253);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(180, 32);
            this.cmbDoktor.TabIndex = 9;
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(140, 205);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(180, 32);
            this.cmbBrans.TabIndex = 8;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(140, 149);
            this.msksaat.Mask = "90:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(180, 32);
            this.msksaat.TabIndex = 7;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Saat:";
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(140, 95);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(180, 32);
            this.msktarih.TabIndex = 6;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtSekreterId
            // 
            this.txtSekreterId.Location = new System.Drawing.Point(140, 47);
            this.txtSekreterId.Name = "txtSekreterId";
            this.txtSekreterId.Size = new System.Drawing.Size(180, 32);
            this.txtSekreterId.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tc Kimlik No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Doktor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Branş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "İd:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(908, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(624, 354);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(911, 384);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(624, 322);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(618, 291);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDuyurular);
            this.groupBox6.Controls.Add(this.btnRandevuListesi);
            this.groupBox6.Controls.Add(this.btnBransPanel);
            this.groupBox6.Controls.Add(this.btnDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 540);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(871, 156);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnRandevuListesi
            // 
            this.btnRandevuListesi.Location = new System.Drawing.Point(417, 58);
            this.btnRandevuListesi.Name = "btnRandevuListesi";
            this.btnRandevuListesi.Size = new System.Drawing.Size(215, 44);
            this.btnRandevuListesi.TabIndex = 2;
            this.btnRandevuListesi.Text = "Randevu Listesi";
            this.btnRandevuListesi.UseVisualStyleBackColor = true;
            this.btnRandevuListesi.Click += new System.EventHandler(this.btnRandevuListesi_Click);
            // 
            // btnBransPanel
            // 
            this.btnBransPanel.Location = new System.Drawing.Point(199, 58);
            this.btnBransPanel.Name = "btnBransPanel";
            this.btnBransPanel.Size = new System.Drawing.Size(197, 44);
            this.btnBransPanel.TabIndex = 1;
            this.btnBransPanel.Text = "Branş Paneli";
            this.btnBransPanel.UseVisualStyleBackColor = true;
            this.btnBransPanel.Click += new System.EventHandler(this.btnBransPanel_Click);
            // 
            // btnDoktorPanel
            // 
            this.btnDoktorPanel.Location = new System.Drawing.Point(6, 58);
            this.btnDoktorPanel.Name = "btnDoktorPanel";
            this.btnDoktorPanel.Size = new System.Drawing.Size(169, 44);
            this.btnDoktorPanel.TabIndex = 0;
            this.btnDoktorPanel.Text = "Doktor Paneli";
            this.btnDoktorPanel.UseVisualStyleBackColor = true;
            this.btnDoktorPanel.Click += new System.EventHandler(this.btnDoktorPanel_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(638, 58);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(215, 44);
            this.btnDuyurular.TabIndex = 3;
            this.btnDuyurular.Text = "Duyuru Listesi";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // frm_SekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1545, 713);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_SekreterDetay";
            this.Text = "SekreterDetay";
            this.Load += new System.EventHandler(this.frm_SekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblSekreterAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSekreterTcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.RichTextBox txtDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.TextBox txtSekreterId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBransPanel;
        private System.Windows.Forms.Button btnDoktorPanel;
        private System.Windows.Forms.Button btnRandevuListesi;
        private System.Windows.Forms.Button btnDuyurular;
    }
}