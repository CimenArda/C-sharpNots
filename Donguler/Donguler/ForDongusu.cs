namespace Donguler
{
    public partial class ForDongusu : Form
    {
        /*
            For(1,2,3)
            1:Baþlangýç
            2:Bitiþ
            3:Azalýþ/Artýþ

          */


        public ForDongusu()
        {
            InitializeComponent();
        }

        private void ForDongusu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");

            int i;
            for (i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i + "Merhaba");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                listBox2.Items.Add(i);
            }
        }

    }
}
