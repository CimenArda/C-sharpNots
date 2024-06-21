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
    public partial class FormlarArasiVeriTasima : Form
    {
        public FormlarArasiVeriTasima()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FormlarArasiVeriTasima --> FormlarArasiVeriTasima2(buranın loadına dikkat edelim) 


            FormlarArasiVeriTasima2 frm = new();

            frm.mesaj = textBox1.Text;

            frm.Show();
            this.Hide();



        }
    }
}
