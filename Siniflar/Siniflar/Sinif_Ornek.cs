using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar
{
    public partial class Sinif_Ornek : Form
    {
        public Sinif_Ornek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Sinif_Ornek_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.Renk = "Mavi";
            rb.hiz = 160;
            rb.motor = 1.6;
            rb.Fiyat =500000;
            rb.Durum = 'S';

            label1.Text = rb.Renk;
            label2.Text = rb.hiz.ToString();
            label3.Text= rb.motor.ToString();
            label4.Text= rb.Fiyat.ToString();
            label5.Text= rb.Durum.ToString();

        }
    }
}
