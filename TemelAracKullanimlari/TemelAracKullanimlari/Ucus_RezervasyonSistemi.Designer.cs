namespace TemelAracKullanimlari
{
    partial class Ucus_RezervasyonSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ucus_RezervasyonSistemi));
            groupBox1 = new GroupBox();
            label9 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label6 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(64, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 362);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(318, 285);
            label9.Name = "label9";
            label9.Size = new Size(66, 28);
            label9.TabIndex = 9;
            label9.Text = "label9";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(314, 100);
            button2.Name = "button2";
            button2.Size = new Size(87, 42);
            button2.TabIndex = 8;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(157, 240);
            maskedTextBox1.Mask = "90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 34);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 240);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 6;
            label4.Text = "Saat:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(157, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 34);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 186);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "İstanbul", "Bursa", "Adana" });
            comboBox2.Location = new Point(157, 124);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 36);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "İstanbul", "Bursa", "Adana" });
            comboBox1.Location = new Point(157, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 127);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 71);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "Nereden :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(496, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 352);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(201, 265);
            button1.Name = "button1";
            button1.Size = new Size(193, 45);
            button1.TabIndex = 7;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 212);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 6;
            label7.Text = "Telefon :";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(204, 206);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(190, 34);
            maskedTextBox3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 145);
            label6.Name = "label6";
            label6.Size = new Size(140, 28);
            label6.TabIndex = 4;
            label6.Text = "TC Kimlik No :";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(204, 139);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(190, 34);
            maskedTextBox2.TabIndex = 3;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 34);
            textBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 72);
            label5.Name = "label5";
            label5.Size = new Size(159, 28);
            label5.TabIndex = 1;
            label5.Text = "Yolcu Ad-Soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(64, 478);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(889, 116);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(64, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 89);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(646, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(3, 16);
            label8.Name = "label8";
            label8.Size = new Size(268, 38);
            label8.TabIndex = 0;
            label8.Text = "Jüpiter Hava Yolları";
            // 
            // Ucus_RezervasyonSistemi
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 611);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Ucus_RezervasyonSistemi";
            Text = "Ucus_RezervasyonSistemi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label7;
        private MaskedTextBox maskedTextBox3;
        private Label label6;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private Label label5;
        private ListBox listBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label8;
        private Button button2;
        private Label label9;
    }
}