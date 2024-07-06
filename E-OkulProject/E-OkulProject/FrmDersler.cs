using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_OkulProject
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=ArdaCimen\\SQLEXPRESS;Initial Catalog=EOkulProject;Integrated Security=True;");

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }
        void Listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtkulupad.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır.");
            Listele();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.DersSil(Convert.ToByte(txtkulupid.Text));
            Listele();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(txtkulupad.Text,Convert.ToByte(txtkulupid.Text));
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              txtkulupid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkulupad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
