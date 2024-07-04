using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetimProjesi
{
    public partial class frm_RandevuListesi : Form
    {
        public frm_RandevuListesi()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void frm_RandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public int secilen;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

             secilen = dataGridView1.SelectedCells[0].RowIndex;

    }
}
}
