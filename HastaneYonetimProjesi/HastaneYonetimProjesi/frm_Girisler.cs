using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetimProjesi
{
    public partial class frm_Girisler : Form
    {
        public frm_Girisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_HastaGiris fr = new frm_HastaGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_DoktorGiris fr = new frm_DoktorGiris();
            fr.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_SekreterGiris fr = new frm_SekreterGiris();
            fr.Show();
            this.Hide();

        }
    }
}
