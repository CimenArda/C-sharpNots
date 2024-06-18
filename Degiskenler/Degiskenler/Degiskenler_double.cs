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
    public partial class Degiskenler_double : Form
    {
        public Degiskenler_double()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 5.17;
            label1.Text = sayi.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, ortalama;
           

            not1=  Convert.ToDouble(textBox1.Text);
            not2 = Convert.ToDouble(textBox2.Text);
            not3 = Convert.ToDouble(textBox3.Text);

            ortalama = (not1+not2+not3)/3;

            label5.Text =ortalama.ToString();
        }
    }
}
