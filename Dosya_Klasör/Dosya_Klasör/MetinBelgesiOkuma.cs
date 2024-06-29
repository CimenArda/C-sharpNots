using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_Klasör
{
    public partial class MetinBelgesiOkuma : Form
    {
        public MetinBelgesiOkuma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {

                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                
                string satir =sr.ReadLine();

                while (satir !=null)
                {
                    listBox1.Items.Add(satir);
                    satir =sr.ReadLine();
                }




                
                sr.Close();

            }
        }
    }
}
