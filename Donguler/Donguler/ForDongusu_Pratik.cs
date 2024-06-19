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
    public partial class ForDongusu_Pratik : Form
    {
        public ForDongusu_Pratik()
        {
            InitializeComponent();
        }

        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                toplam = toplam + i;
            }
            label1.Text = toplam.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam2 = 0;

            for (int i = 2; i <=10; i+=2)
            {
                toplam2 = toplam2 + i;
            }
            label3.Text = toplam2.ToString();



        }
    }
}
