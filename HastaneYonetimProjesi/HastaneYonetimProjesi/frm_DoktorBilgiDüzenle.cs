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
    public partial class frm_DoktorBilgiDüzenle : Form
    {
        public frm_DoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string TCno;
        private void frm_DoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text= TCno;
            SqlCommand komut =new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@p1",bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1",mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                txtSifre.Text = dr[5].ToString();
            }
            bgl.Baglanti().Close();

        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4",txtSifre.Text);
            komut.Parameters.AddWithValue("@p5",mskTc.Text);


            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Bilgi Güncellendi");
        }
    }
}
