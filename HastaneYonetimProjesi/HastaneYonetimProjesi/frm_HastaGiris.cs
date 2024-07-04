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
    public partial class frm_HastaGiris : Form
    {
        public frm_HastaGiris()
        {
            InitializeComponent();
        }


        SqlBaglanti bgl = new SqlBaglanti();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lnkUyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_HastaKayit fr = new frm_HastaKayit();
            fr.Show();
            
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where  HastaTC=@p1 and HastaSifre =@p2",bgl.Baglanti());

            komut.Parameters.AddWithValue("@p1",mskTc.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);

            SqlDataReader dr =komut.ExecuteReader();    

            if (dr.Read())
            {
                frm_HastaDetay fr = new frm_HastaDetay();
                fr.tc = mskTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
            bgl.Baglanti().Close();
        }

        private void frm_HastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
