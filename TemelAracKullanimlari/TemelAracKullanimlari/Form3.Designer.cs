namespace TemelAracKullanimlari
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            label4 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(158, 90);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(233, 38);
            maskedTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 97);
            label1.Name = "label1";
            label1.Size = new Size(96, 31);
            label1.TabIndex = 1;
            label1.Text = "Telefon:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(158, 156);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(233, 38);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 163);
            label2.Name = "label2";
            label2.Size = new Size(46, 31);
            label2.TabIndex = 3;
            label2.Text = "TC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 220);
            label3.Name = "label3";
            label3.Size = new Size(71, 31);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            label3.Click += label3_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(158, 220);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(233, 38);
            maskedTextBox3.TabIndex = 5;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(158, 294);
            maskedTextBox4.Mask = "90:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(233, 38);
            maskedTextBox4.TabIndex = 6;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 301);
            label4.Name = "label4";
            label4.Size = new Size(65, 31);
            label4.TabIndex = 7;
            label4.Text = "Saat:";
            // 
            // button1
            // 
            button1.Location = new Point(158, 390);
            button1.Name = "button1";
            button1.Size = new Size(172, 43);
            button1.TabIndex = 8;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(57, 471);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(539, 159);
            listBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 698);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(maskedTextBox2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private MaskedTextBox maskedTextBox2;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private Label label4;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
    }
}