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
    public partial class Sinif_Ornek2 : Form
    {
        public Sinif_Ornek2()
        {
            InitializeComponent();
        }

        private void Sinif_Ornek2_Load(object sender, EventArgs e)
        {

            Araba rb = new Araba();
            rb.Renk = "Yeşil";
            rb.hiz = 200;
            rb.motor = 1.2;
            rb.Fiyat = 700000;
            rb.Durum = 'İ';

            label1.Text = rb.Renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.Fiyat.ToString();
            label5.Text = rb.Durum.ToString();
        }
    }
}
