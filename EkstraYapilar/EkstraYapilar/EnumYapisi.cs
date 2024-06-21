﻿using System;
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
    public partial class EnumYapisi : Form
    {
        public EnumYapisi()
        {
            InitializeComponent();
        }

        enum sehirler { x,Adana,Adıyaman,Ağrı,Afyon,Amasya,Artvin,Aydın,Ardahan}
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt32(textBox1.Text);

            sehirler s;
            s = (sehirler)plaka;
            label1.Text = s.ToString();
        }
    }
}
