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
    public partial class frm_DoktorDetay : Form
    {
        public frm_DoktorDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl =new SqlBaglanti();
        public string TcNo;
        private void frm_DoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TcNo;


            //Doktor Ad Soyad cekme
            SqlCommand komut =new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1",bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.Baglanti().Close();


            //Randevular

            DataTable dt = new DataTable();
            SqlDataAdapter da =new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='"+lblAdSoyad.Text+"'",bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            frm_DoktorBilgiDüzenle fr = new frm_DoktorBilgiDüzenle();
            fr.TCno = lblTC.Text;
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frm_Duyurular frm_Duyurular = new frm_Duyurular();
            frm_Duyurular.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
