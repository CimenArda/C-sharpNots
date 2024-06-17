using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemelAracKullanimlari
{
    public partial class Ucus_RezervasyonSistemi : Form
    {
        public Ucus_RezervasyonSistemi()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + "-" + comboBox2.Text + " Tarih:" + dateTimePicker1.Text + " Saat:" + maskedTextBox1.Text + "  Bilgileri ~~ Ad :" + textBox1.Text + "TC:" + maskedTextBox2.Text + "Telefon:" + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Yapıldı.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
