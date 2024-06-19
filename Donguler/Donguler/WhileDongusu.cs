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
    public partial class WhileDongusu : Form
    {
        /*
         While(şart)
        {
        işlem
        }
         */
        public WhileDongusu()
        {
            InitializeComponent();
        }

        private void WhileDongusu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 5)
            {
                listBox1.Items.Add("Merhaba");  
                listBox2.Items.Add(i);
                i++;
            }

        }
    }
}
