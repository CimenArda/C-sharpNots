namespace TemelAracKullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void T�klay�n�z_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba D�nya");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Arda";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Arda";
            label6.Text = "�imen";
            label8.Text = "Yaz�l�mc�";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yaz�l�m M�h";
            label9.Text = textBox1.Text;
        }
    }
}
