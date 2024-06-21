using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraYapilar
{
    public partial class MatematikFonksiyonlari : Form
    {
        public MatematikFonksiyonlari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double  sayi =Convert.ToDouble(textBox1.Text);
           
            label2.Text=Math.Abs(sayi).ToString();

            label2.Text=Math.Ceiling(sayi).ToString();

            label2.Text=Math.Floor(sayi).ToString();

            label2.Text=Math.Pow(sayi,1).ToString();

            label2.Text=Math.Sqrt(sayi).ToString();

            label2.Text=Math.PI.ToString();

            label2.Text=Math.Cos(sayi).ToString();
            
                                                    




        }
    }
}
/* 
 Abs:Mutlak
Ceil =Üste yuvarlama
Floor =alta yuvarlama
pow =üs 
SQRT =kare kök
PI =3.14234353413412423412
Cos =cosinüs
 */