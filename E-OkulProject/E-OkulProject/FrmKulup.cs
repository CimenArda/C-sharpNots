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
namespace E_OkulProject
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ArdaCimen\\SQLEXPRESS;Initial Catalog=EOkulProject;Integrated Security=True;");

      void Listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Kulupler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmKulup_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            Listele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Tbl_Kulupler (KulupAd) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtkulupad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kulüp Listeye Eklendi");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkulupid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkulupad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Tbl_Kulupler where KulupId=@p1", baglanti);

            komut.Parameters.AddWithValue("@p1", txtkulupid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Silindi");
            Listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Kulupler set KulupAd =@p1 where KulupId =@p2", baglanti);

            komut.Parameters.AddWithValue("@p1", txtkulupad.Text);
            komut.Parameters.AddWithValue("@p2", txtkulupid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulup Güncellendi");
            Listele();
        }
    }
}
