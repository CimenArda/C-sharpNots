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
    public partial class frm_SekreterDetay : Form
    {
        public frm_SekreterDetay()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        SqlBaglanti bgl = new SqlBaglanti();

        public string Tcnumara;
        private void frm_SekreterDetay_Load(object sender, EventArgs e)
        {
            lblSekreterTcNo.Text = Tcnumara;


            //Ad-Soyad veri cekimi
            SqlCommand komut1 =new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC =@p1 ",bgl.Baglanti());

            komut1.Parameters.AddWithValue("@p1",lblSekreterTcNo.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblSekreterAdSoyad.Text = dr1[0].ToString();

            }

            bgl.Baglanti().Close();


            //Bransları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd from Tbl_Branslar", bgl.Baglanti());

            da.Fill(dt1);   
            dataGridView1.DataSource = dt1;


            //Doktorlaı datagride aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", bgl.Baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı cmb ye aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.Baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@r1,@r2,@r3,@r4)", bgl.Baglanti());
            komutkaydet.Parameters.AddWithValue("@r1",msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2",msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4",cmbDoktor.Text);

            komutkaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.Baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);

            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] +" "+ dr3[1]);
            }
            bgl.Baglanti().Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@d1", txtDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti() .Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            frm_DoktorPaneli fr = new frm_DoktorPaneli();
            fr.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            frm_BransPaneli fr = new frm_BransPaneli(); 
            fr.Show();
        }

        private void btnRandevuListesi_Click(object sender, EventArgs e)
        {
            frm_RandevuListesi fr = new frm_RandevuListesi();
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frm_Duyurular fr = new frm_Duyurular();
            fr.Show();
        }
    }
}
