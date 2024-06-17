namespace TemelAracKullanimlari
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(263, 166);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(174, 38);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 173);
            label1.Name = "label1";
            label1.Size = new Size(222, 31);
            label1.TabIndex = 1;
            label1.Text = "TC Kimlik Numarası:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 38);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 231);
            label2.Name = "label2";
            label2.Size = new Size(68, 31);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 139);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(562, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 35);
            label3.Name = "label3";
            label3.Size = new Size(390, 46);
            label3.TabIndex = 0;
            label3.Text = "Online Ders Giriş Paneli";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Location = new Point(-2, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 65);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(263, 282);
            button1.Name = "button1";
            button1.Size = new Size(149, 40);
            button1.TabIndex = 6;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(33, 287);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(207, 35);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Şifremi Unuttum";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 505);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "LoginPanel";
            Text = "Kullanıcı Giriş Paneli";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private CheckBox checkBox1;
    }
}