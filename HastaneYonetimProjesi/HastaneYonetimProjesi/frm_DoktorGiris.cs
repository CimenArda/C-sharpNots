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
    public partial class frm_DoktorGiris : Form
    {
        public frm_DoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre =@p2",bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frm_DoktorDetay fr = new frm_DoktorDetay();
                fr.TcNo = mskTC.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı bilgi");
            }
            bgl.Baglanti().Close();

        }

        private void frm_DoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
