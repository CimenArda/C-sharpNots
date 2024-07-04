using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HastaneYonetimProjesi
{
    public partial class frm_Duyurular : Form
    {
        public frm_Duyurular()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void frm_Duyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Duyurular",bgl.Baglanti());

            da.Fill(dt);    
            dataGridView1.DataSource = dt;


        }
    }
}
