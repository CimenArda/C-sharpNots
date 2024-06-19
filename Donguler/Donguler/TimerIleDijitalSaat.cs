using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class TimerIleDijitalSaat : Form
    {
        public TimerIleDijitalSaat()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            saniye++;
            label1.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                if (dakika == 60)
                {
                    saat++;
                    label3.Text = saat.ToString();
                    dakika = 0;
                }

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void TimerIleDijitalSaat_Load(object sender, EventArgs e)
        {

        }
    }
}
