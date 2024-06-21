namespace EkstraYapilar
{
    public partial class RandomKomutu : Form
    {
        public RandomKomutu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int sayi;
            sayi = rd.Next(1, 10);

            label1.Text = sayi.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int s1, s2, s3;
            s1 = rnd.Next(1, 5);
            s2 = rnd.Next(1, 5);
            s3 = rnd.Next(1, 5);

            label2.Text = s1.ToString();
            label3.Text = s2.ToString();
            label4.Text = s3.ToString();
        }
    }
}
