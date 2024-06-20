﻿using System;
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
    public partial class DiziElemanlarıListeleme : Form
    {
        public DiziElemanlarıListeleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Ankara", "Eskişehir", "Antalya", "Adana", "Bursa", "Balıkesir" };

            for (int i = 0; i < sehirler.Length; i++)
            {
                listBox1.Items.Add(sehirler[i]);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = {1,233,445,6,7235,8768,34523,1231,89,66,12 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]%2==0)
                {
                    listBox2.Items.Add(sayilar[i]);
                }

            }
        }
    }
}
