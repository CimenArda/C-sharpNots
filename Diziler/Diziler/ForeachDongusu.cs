using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class ForeachDongusu : Form
    {




        /*
         foreach(1,2,3,4)
        1=Değişken türü
        2=Degisken adı
        3=in (içinden)
        4= Dizi Adı
         */


        public ForeachDongusu()
        {
            InitializeComponent();
        }

        private void ForeachDongusu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Ahmet", "Ayşe", "Mehmet", "Yavuz", "Selim", "Mine", "Musa" };

            foreach (string k in kisiler)
            {
                listBox1.Items.Add(k);
            }
        }

        int toplam = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int[] sınavlar = {70,87,93,55,100,89};

            foreach (int s in sınavlar)
            {
                listBox2.Items.Add(s);
                toplam +=s;
                label1.Text = toplam.ToString();

                int ortalama = toplam / sınavlar.Length;
                label2.Text= ortalama.ToString();   
            }
        }
    }
}
