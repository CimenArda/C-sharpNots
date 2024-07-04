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
    public partial class frm_BilgiDüzenle : Form
    {
        public frm_BilgiDüzenle()
        {
            InitializeComponent();
        }

        public string tcno;
        private void frm_BilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = tcno;
        }
    }
}
