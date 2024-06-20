using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class KupHesaplayanMetot_Pratik : Form
    {
        public KupHesaplayanMetot_Pratik()
        {
            InitializeComponent();
        }

        int kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox1.Text);

            label1.Text= kup(s).ToString();

        }
    }
}
