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
    public partial class frm_DoktorPaneli : Form
    {
        public frm_DoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void frm_DoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select *  from Tbl_Doktorlar", bgl.Baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branşları cmbye aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.Baglanti().Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre)values (@d1,@d2,@d3,@d4,@d5)",bgl.Baglanti());

            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);

            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Doktor Eklenmiştir.");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC =@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.ExecuteNonQuery();    
            bgl.Baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.Baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);

            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Doktor Güncellenmiştir.");

        }
    }
}
