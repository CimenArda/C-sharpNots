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
    public partial class frm_HastaKayit : Form
    {
        public frm_HastaKayit()
        {
            InitializeComponent();
        }


        SqlBaglanti bgl = new SqlBaglanti();


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.Baglanti());



            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",mskTc.Text);
            komut.Parameters.AddWithValue("@p4",mskTelNo.Text);
            komut.Parameters.AddWithValue("@p5",txtSifre.Text);
            komut.Parameters.AddWithValue("@p6",cmbCinsiyet.Text);

            komut.ExecuteNonQuery();

            bgl.Baglanti().Close();

            MessageBox.Show("Kaydınız Gerçekleştirmiştir."+" " +"Şifreniz:"+txtSifre.Text);
            

        }
    }
}
