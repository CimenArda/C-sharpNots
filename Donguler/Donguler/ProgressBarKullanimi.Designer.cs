namespace Donguler
{
    partial class ProgressBarKullanimi
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
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(140, 89);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(228, 45);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(180, 150);
            button1.Name = "button1";
            button1.Size = new Size(41, 29);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(240, 150);
            button2.Name = "button2";
            button2.Size = new Size(49, 29);
            button2.TabIndex = 2;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(195, 205);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ProgressBarKullanimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Name = "ProgressBarKullanimi";
            Text = "ProgressBarKullanimi";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}