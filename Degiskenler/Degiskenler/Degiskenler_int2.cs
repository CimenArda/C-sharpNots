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
    public partial class Degiskenler_int2 : Form
    {
        public Degiskenler_int2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            label2.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1,sonuc;

            sayi1 = Convert.ToInt32(textBox2.Text);

            sonuc = sayi1 * sayi1*sayi1;

            label4.Text = sonuc.ToString();
          
        }
    }
}
