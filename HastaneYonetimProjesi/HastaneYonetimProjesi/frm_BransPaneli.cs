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
    public partial class frm_BransPaneli : Form
    {
        public frm_BransPaneli()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void frm_BransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da =new SqlDataAdapter("Select * from Tbl_Branslar ",bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Branslar (BransAd) values (@p1)",bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();

            MessageBox.Show("Branş Eklendi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;  
            txtİd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
           txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Branslar where Bransid=@b1", bgl.Baglanti());

            komut.Parameters.AddWithValue("@b1",txtİd.Text);

            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Branş Silindi");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Branslar set BransAd=@b1 where Bransid=@b2", bgl.Baglanti());

            komut.Parameters.AddWithValue("@b1", txtAd.Text);
            komut.Parameters.AddWithValue("@b2", txtİd.Text);

            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Branş Güncellendi");

        }
    }
}
