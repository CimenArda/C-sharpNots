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
    public partial class FormlarArasiVeriTasima2 : Form
    {
        public FormlarArasiVeriTasima2()
        {
            InitializeComponent();
        }

        public string mesaj;

        private void FormlarArasiVeriTasima2_Load(object sender, EventArgs e)
        {
            label1.Text = mesaj;
        }
    }
}
