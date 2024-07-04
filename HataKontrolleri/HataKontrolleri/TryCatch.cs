using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataKontrolleri
{
    public partial class TryCatch : Form
    {
        public TryCatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);

                int toplam = sayi1 + sayi2;

                MessageBox.Show(toplam.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Boş geçtiniz ve ya Yanlış Değerler Girdiniz.");
            }
           
        }
    }
}
