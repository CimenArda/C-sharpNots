using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_OkulProject
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup fr =new FrmKulup();
            fr.Show();
        }

        private void btnDersİslemler_Click(object sender, EventArgs e)
        {
            FrmDersler fr =new FrmDersler();
            fr.Show();
        }

        private void btnOgrenciIsleri_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr =new FrmOgrenci();    
            fr.Show();
        }

        private void btnSinavNotlari_Click(object sender, EventArgs e)
        {
           FrmOgrenciNotlar fr =new FrmOgrenciNotlar();
            fr.Show();
            
        }
    }
}
