using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Dosya_Klasör
{
    public partial class MetinBelgesiVeriKaydetme : Form
    {
        public MetinBelgesiVeriKaydetme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = " Metin Dosyaları|*.txt";
            saveFileDialog1.Title = "Metin Belgesi Kayıt";
            saveFileDialog1.ShowDialog();

            StreamWriter sw =new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();

            MessageBox.Show("Kayıt Oluşturuldu");
        }
    }
}
