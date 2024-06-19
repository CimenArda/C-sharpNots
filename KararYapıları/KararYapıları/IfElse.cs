namespace KararYapıları
{
    public partial class IfElse : Form
    {
        public IfElse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Arda")
            {
                label1.Text = "Doğru Kişi";
            }
            else
            {
                label1.Text = "yanlış kişi";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text);
            if (sayi <= 5)
            {
                label2.Text = "Sayı 5 ten küçük  veya eşit ";
            }
            else
            {
                label2.Text = "Sayı 5 ten büyük";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox3.Text);
            if (sayi % 2 == 0)
            {
                label3.Text = "Girilen Sayı Çifttir.";

            }
            else
            {
                label3.Text = "Girilen sayı tektir";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox4.Text);
            if (sayi % 2 == 0 && sayi >=10)
            {
                label4.Text = "Girilen Sayı Çifttir ve 10 dan büyüktür";

            }
            else
            {
                label4.Text = "Girilen sayı tektir veya 10 dan küçüktür.";
            }
        }
    }
}
