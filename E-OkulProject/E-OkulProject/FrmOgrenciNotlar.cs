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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti =new SqlConnection("Data Source=ArdaCimen\\SQLEXPRESS;Initial Catalog=EOkulProject;Integrated Security=True;");

        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "DersAd";
            comboBox1.ValueMember = "DersId";
            comboBox1.DataSource = dt;
            baglanti.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotlariGetir(int.Parse(txtogrenciid.Text));
        }

        int notid;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtogrenciid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

        }
        int sinav1, sinav2, sinav3, proje;
        double ortalama;
        string durum;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
       
            sinav1=Convert.ToInt16(txtsınav1.Text);
            sinav2 = Convert.ToInt16(txtsınav2.Text);
            sinav3 = Convert.ToInt16(txtsınav3.Text);
            proje = Convert.ToInt16(txtproje.Text);

            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtortalama.Text = ortalama.ToString();
            if (ortalama>=50)
            {

                txtdurum.Text = "True";
            }
            else
            {
                txtdurum.Text="False";
            }

        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGüncelle(byte.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txtogrenciid.Text), byte.Parse(txtsınav1.Text), byte.Parse(txtsınav2.Text), byte.Parse(txtsınav3.Text), byte.Parse(txtproje.Text), decimal.Parse(txtortalama.Text),  bool.Parse(txtdurum.Text), notid);
        }
    }
}
