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
    public partial class KapsullemeVeKalıtım : Form
    {
        public KapsullemeVeKalıtım()
        {
            InitializeComponent();
        }

        private void Kapsulleme_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.Renk = "Mavi";
            rb.hiz = 160;
            rb.motor = 1.6;
            rb.Fiyat = 500000;
            rb.Durum = 'S';

            rb.YIL = -2015;
            rb.Markasi = "Cla 200";

            rb.muayene = 2007;
            rb.plaka = "34 KV 058";
            rb.sahip = "Arda Cimen";

            label10.Text = rb.Renk;
            label9.Text = rb.hiz.ToString();
            label8.Text = rb.motor.ToString();
            label7.Text = rb.Fiyat.ToString();
            label6.Text = rb.Durum.ToString();
            label11.Text = rb.YIL.ToString();
            label12.Text = rb.Markasi;
            label13.Text = rb.muayene.ToString();
            label14.Text = rb.plaka;
            label15.Text = rb.sahip;



        }
    }
}
