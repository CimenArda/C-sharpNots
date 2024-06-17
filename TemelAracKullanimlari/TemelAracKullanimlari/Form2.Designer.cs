namespace TemelAracKullanimlari
{
    partial class Form2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa", "Ankara", "Balıkesir", "Gaziantep", "Elazığ", "Malatya", "İstanbul", "İzmir" });
            comboBox1.Location = new Point(176, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(377, 39);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(274, 87);
            button1.Name = "button1";
            button1.Size = new Size(196, 57);
            button1.TabIndex = 1;
            button1.Text = "Şehir ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1023, 87);
            button2.Name = "button2";
            button2.Size = new Size(153, 57);
            button2.TabIndex = 2;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(908, 36);
            label1.Name = "label1";
            label1.Size = new Size(74, 31);
            label1.TabIndex = 3;
            label1.Text = "Şehir:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1023, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 38);
            textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Items.AddRange(new object[] { "Öğretmen", "Doktor", "Mühendis ", "Hemşire" });
            listBox1.Location = new Point(176, 303);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 159);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(176, 492);
            button3.Name = "button3";
            button3.Size = new Size(146, 52);
            button3.TabIndex = 6;
            button3.Text = "Meslek Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(723, 413);
            button4.Name = "button4";
            button4.Size = new Size(145, 49);
            button4.TabIndex = 7;
            button4.Text = "Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(609, 340);
            label2.Name = "label2";
            label2.Size = new Size(94, 31);
            label2.TabIndex = 8;
            label2.Text = "Meslek:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(723, 340);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 38);
            textBox2.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1908, 1051);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
    }
}