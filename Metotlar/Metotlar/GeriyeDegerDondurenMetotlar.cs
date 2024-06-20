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
    public partial class GeriyeDegerDondurenMetotlar : Form
    {
        public GeriyeDegerDondurenMetotlar()
        {
            InitializeComponent();
        }


        int Toplam(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(3, 55).ToString();
            label2.Text = Toplam(14, 52).ToString();
            label3.Text = Toplam(5, 5).ToString();
        }
    }
}
