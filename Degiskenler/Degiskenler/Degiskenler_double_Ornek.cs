using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Degiskenler_double_Ornek : Form
    {
        public Degiskenler_double_Ornek()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad= textBox1.Text;
            soyad = textBox2.Text;

            double sınav1, sınav2, sınav3,ortalama;
            sınav1 = Convert.ToDouble(textBox3.Text);
            sınav2 = Convert.ToDouble(textBox4.Text);
            sınav3 = Convert.ToDouble(textBox5.Text);

            ortalama = (sınav1 + sınav2 + sınav3) / 3;

            listBox1.Items.Add("Ogrenci:" + ad + " " + soyad + " " + "Not Ortalaması:" + ortalama);





        }
    }
}
