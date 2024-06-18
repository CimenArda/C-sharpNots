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
    public partial class Degiskenler_Sinema_Bufe_Satis : Form
    {
        public Degiskenler_Sinema_Bufe_Satis()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        int kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir =Convert.ToInt32(TxtMisir.Text);
            bilet = Convert.ToInt32(TxtBilet.Text);
            su = Convert.ToInt32(TxtSu.Text);
            cay = Convert.ToInt32(TxtCay.Text);



            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;

            LblToplam.Text =toplam.ToString() + "TL";

            kasaTutar = kasaTutar + toplam;

            LblKasaToplam.Text =kasaTutar.ToString()+"TL";



        }
    }
}
