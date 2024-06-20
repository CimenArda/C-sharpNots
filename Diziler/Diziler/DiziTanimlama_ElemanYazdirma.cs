namespace Diziler
{
    public partial class DiziTanimlama_ElemanYazdirma : Form
    {
        public DiziTanimlama_ElemanYazdirma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Ahmet", "Veli", "Demet", "Ayþe", "Melisa", "Ýbrahim" };
            label1.Text = kisiler[4];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = {1,23,4,5,6,777,8,89,214,2134 };

            label2.Text = sayilar[5].ToString();
        }


    }
}
