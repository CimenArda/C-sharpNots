namespace Metotlar
{
    public partial class GeriyeDegerDondurmeyenMetotlar : Form
    {
        public GeriyeDegerDondurmeyenMetotlar()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        void renklendir()
        {
            textBox1.BackColor = Color.Green;
            textBox5.BackColor = Color.Blue;
            textBox3.BackColor = Color.Red;
            textBox4.BackColor = Color.Yellow;
        } 



        private void button1_Click(object sender, EventArgs e)
        {
            temizle();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
    }
}
