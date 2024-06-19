using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapıları
{
    public partial class Alisveris_Indirim_Hesaplama : Form
    {
        public Alisveris_Indirim_Hesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt16(textBox1.Text);
            if (kitapadet>=0 &&kitapadet<=20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label3.Text =toplam.ToString() +"TL";
            }
            else if(kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label3.Text = toplam.ToString() + "TL";

            }
            else
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                label3.Text = toplam.ToString() + "TL";
            }






        }

        // 0-20 =>%20
        // 21-40 =>%40
        // 41++ =>%40

        //Kitap 8TL
    }
}
