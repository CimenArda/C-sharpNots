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
    public partial class SayisalLotoUygulamasi : Form
    {
        public SayisalLotoUygulamasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int sayi1 ,sayi2,sayi3,sayi4 ;

            sayi1 = rast.Next(1,5);
            sayi2 = rast.Next(1,5);
            sayi3 = rast.Next(1,5);
            sayi4 = rast.Next(1,5);

            label1.Text =sayi1.ToString();
            label2.Text =sayi2.ToString();
            label3.Text =sayi3.ToString();
            label4.Text =sayi4.ToString();


            if(textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;

            }

            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;

            }


            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;

            }
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;

            }


        }
    }
}
