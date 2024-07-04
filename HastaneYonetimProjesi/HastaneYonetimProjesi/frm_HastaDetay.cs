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
    public partial class frm_HastaDetay : Form
    {
        public frm_HastaDetay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        public string tc;

        SqlBaglanti bgl = new SqlBaglanti();
        private void frm_HastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;

            //Ad Soyad Verisi Cekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC =@p1",bgl.Baglanti());


            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            
            SqlDataReader dr =komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.Baglanti().Close();


            //Randevu Geçmişi
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTC =" + tc, bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Brans Verilerini Cekme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.Baglanti());

            SqlDataReader dr2 =komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }

            bgl.Baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuBrans='"+cmbBrans.Text+"'" +" and RandevuDoktor='"+cmbDoktor.Text+"' and RandevuDurum =0",bgl.Baglanti());


            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.Baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);

            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.Baglanti().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_BilgiDüzenle fr =new frm_BilgiDüzenle();
            fr.tcno = lblTC.Text;
            fr.Show();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum =1,HastaTc=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Randevu Alındı");
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;  
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
