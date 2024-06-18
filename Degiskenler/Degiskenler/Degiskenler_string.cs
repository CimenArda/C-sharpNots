namespace Degiskenler
{
    public partial class Degiskenler_string : Form
    {
        public Degiskenler_string()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin;
            metin = "Merhaba bugün 18 haziran salý";
            label1.Text = metin;

            string adsoyad, meslek;
            adsoyad = "Arda Çimen";
            meslek = "Öðretmen";
            label2.Text = adsoyad;
            label3.Text = meslek;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sehir;
            sehir =  textBox1.Text;

            label4.Text = sehir;
        }
    }
}
