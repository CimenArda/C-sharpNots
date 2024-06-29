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
    public partial class MetinBelgesi : Form
    {
        public MetinBelgesi()
        {
            InitializeComponent();
        }

        string dosyaadi, dosyayolu;
        StreamWriter sw;
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() ==DialogResult.OK)
            {

                dosyayolu =folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyayolu;

                sw = File.CreateText(dosyayolu + "\\" + dosyaadi + ".txt");
                sw.Close();




            }
        }
    }
}
