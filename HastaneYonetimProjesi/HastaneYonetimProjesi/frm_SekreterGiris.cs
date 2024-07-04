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
    public partial class frm_SekreterGiris : Form
    {
        public frm_SekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Sekreter where SekreterTC =@p1 and SekreterSifre=@p2",bgl.Baglanti());

            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);

            SqlDataReader dr =komut.ExecuteReader();
            if (dr.Read())
            {
                frm_SekreterDetay frs =new frm_SekreterDetay();
                frs.Tcnumara = mskTC.Text;
                frs.Show();

            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
            }
            bgl.Baglanti().Close();


        }
    }
}
