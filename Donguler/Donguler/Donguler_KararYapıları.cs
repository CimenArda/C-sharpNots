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
    public partial class Donguler_KararYapıları : Form
    {
        public Donguler_KararYapıları()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 3; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    listBox1.Items.Add(i);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 3; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    listBox2.Items.Add(i);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < sayi; i++)
            {
                listBox3.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text);

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    listBox4.Items.Add(i); 
                }

            }

        }
    }
}
