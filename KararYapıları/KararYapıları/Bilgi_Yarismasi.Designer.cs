namespace KararYapıları
{
    partial class Bilgi_Yarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilgi_Yarismasi));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            lblSoruNo = new Label();
            LblYanlis = new Label();
            lblDogru = new Label();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(-3, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(581, 180);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(-3, 176);
            btnA.Name = "btnA";
            btnA.Size = new Size(291, 52);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += button1_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(283, 176);
            btnB.Name = "btnB";
            btnB.Size = new Size(295, 52);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(-7, 225);
            btnC.Name = "btnC";
            btnC.Size = new Size(295, 52);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(283, 225);
            btnD.Name = "btnD";
            btnD.Size = new Size(295, 52);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(641, 21);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(78, 22);
            Lbl1.TabIndex = 5;
            Lbl1.Text = "Soru No:";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(641, 57);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(63, 22);
            Lbl2.TabIndex = 6;
            Lbl2.Text = "Doğru:";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Location = new Point(641, 98);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(61, 22);
            Lbl3.TabIndex = 7;
            Lbl3.Text = "Yanlış:";
            // 
            // lblSoruNo
            // 
            lblSoruNo.AutoSize = true;
            lblSoruNo.Location = new Point(725, 21);
            lblSoruNo.Name = "lblSoruNo";
            lblSoruNo.Size = new Size(19, 22);
            lblSoruNo.TabIndex = 8;
            lblSoruNo.Text = "0";
            // 
            // LblYanlis
            // 
            LblYanlis.AutoSize = true;
            LblYanlis.Location = new Point(725, 98);
            LblYanlis.Name = "LblYanlis";
            LblYanlis.Size = new Size(19, 22);
            LblYanlis.TabIndex = 9;
            LblYanlis.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(725, 57);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(19, 22);
            lblDogru.TabIndex = 10;
            lblDogru.Text = "0";
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(632, 140);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(295, 52);
            btnSonraki.TabIndex = 11;
            btnSonraki.Text = "Sonraki Soru";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(594, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(750, 238);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 390);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 14;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 390);
            label2.Name = "label2";
            label2.Size = new Size(57, 22);
            label2.TabIndex = 15;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // Bilgi_Yarismasi
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 385);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSonraki);
            Controls.Add(lblDogru);
            Controls.Add(LblYanlis);
            Controls.Add(lblSoruNo);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bilgi_Yarismasi";
            Text = "Bilgi_Yarismasi";
            Load += Bilgi_Yarismasi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private Label lblSoruNo;
        private Label LblYanlis;
        private Label lblDogru;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}