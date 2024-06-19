using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapıları
{
    public partial class Ogrenci_Sinav_Durumu_Hesaplama : Form
    {
        public Ogrenci_Sinav_Durumu_Hesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sınav1, sınav2, proje, ortalama;

            string durum;

            sınav1 = Convert.ToInt32(textBox1.Text);
            sınav2 = Convert.ToInt32(textBox2.Text);

            proje = Convert.ToInt32(textBox3.Text);

            ortalama = (sınav1 + sınav2 + proje) / 3;
            if (ortalama >=50)
            {
                durum = "Geçtiniz";


            }
            else
            {
                durum = "Kaldınız";
            }
            textBox4.Text="Ortalamanız:" + ortalama.ToString("0.00") +"/"+ durum;
        }
    }
}
