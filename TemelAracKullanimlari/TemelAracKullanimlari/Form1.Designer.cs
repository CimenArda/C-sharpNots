namespace TemelAracKullanimlari
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 207);
            button1.Name = "button1";
            button1.Size = new Size(178, 67);
            button1.TabIndex = 0;
            button1.Text = "Tıklayınız";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Tıklayınız_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 1;
            label1.Text = "Adınız :";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 129);
            button2.Name = "button2";
            button2.Size = new Size(134, 46);
            button2.TabIndex = 2;
            button2.Text = "Yazdır";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(107, 47);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 55);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Adınız:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(632, 55);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 108);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 6;
            label5.Text = "Soyadınız:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(632, 108);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(538, 155);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 8;
            label7.Text = "Mesleğiniz:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(632, 155);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 9;
            label8.Text = "label8";
            // 
            // button3
            // 
            button3.BackColor = Color.Sienna;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(538, 207);
            button3.Name = "button3";
            button3.Size = new Size(130, 41);
            button3.TabIndex = 10;
            button3.Text = "Bilgi Getir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 318);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 27);
            textBox1.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(52, 367);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 12;
            button4.Text = "Aktar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(216, 357);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 13;
            label9.Text = "label9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(1147, 695);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Araç Kullanımları";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Label label9;
    }
}
