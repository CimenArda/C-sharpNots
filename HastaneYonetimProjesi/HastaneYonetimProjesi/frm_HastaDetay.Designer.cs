namespace HastaneYonetimProjesi
{
    partial class frm_HastaDetay
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
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.txtSikayet = new System.Windows.Forms.RichTextBox();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(133, 96);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(56, 22);
            this.LblAdSoyad.TabIndex = 4;
            this.LblAdSoyad.Text = "NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(117, 48);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(109, 22);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbDoktor);
            this.groupBox2.Controls.Add(this.txtSikayet);
            this.groupBox2.Controls.Add(this.btnRandevuAl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbBrans);
            this.groupBox2.Location = new System.Drawing.Point(33, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 447);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Al";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(121, 47);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(185, 29);
            this.txtid.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 22);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bilgilerini Düzenle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şikayet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Doktor";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(121, 142);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(185, 30);
            this.cmbDoktor.TabIndex = 5;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(121, 194);
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(185, 157);
            this.txtSikayet.TabIndex = 3;
            this.txtSikayet.Text = "";
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(121, 373);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(164, 34);
            this.btnRandevuAl.TabIndex = 4;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Branş";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(121, 81);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(185, 30);
            this.cmbBrans.TabIndex = 0;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(482, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(915, 352);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(909, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(482, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(915, 352);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(909, 324);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // frm_HastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1411, 846);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_HastaDetay";
            this.Text = "HastaDetay";
            this.Load += new System.EventHandler(this.frm_HastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.RichTextBox txtSikayet;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
    }
}