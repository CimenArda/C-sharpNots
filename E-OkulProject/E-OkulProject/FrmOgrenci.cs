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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        DataSet1TableAdapters.Tbl_OgrencilerTableAdapter ds = new DataSet1TableAdapters.Tbl_OgrencilerTableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=ArdaCimen\\SQLEXPRESS;Initial Catalog=EOkulProject;Integrated Security=True;");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Kulupler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbkulüp.DisplayMember = "KulupAd";
            cmbkulüp.ValueMember = "KulupId";
            cmbkulüp.DataSource = dt;
            baglanti.Close();


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
           
        }
        string c = "";

        private void btnekle_Click(object sender, EventArgs e)
        {
         
            ds.OgrenciEkle(txtogrenciad.Text,txtogrencisoyad.Text,byte.Parse(cmbkulüp.SelectedValue.ToString()),c);
            MessageBox.Show("Öğrenci Eklenmiştir");
        }

        private void cmbkulüp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtogrenciid.Text =cmbkulüp.SelectedValue.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.DeleteQuery(int.Parse(txtogrenciid.Text));
            MessageBox.Show("Öğrenci Silinmiştir");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtogrenciid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtogrenciad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtogrencisoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbkulüp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            ds.OgrenciGuncelle(txtogrenciad.Text, txtogrencisoyad.Text, byte.Parse(cmbkulüp.SelectedValue.ToString()), c, int.Parse(txtogrenciid.Text));
            MessageBox.Show("Kulup Güncellendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "Erkek";
            }
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
            if (radioButton2.Checked == true)
            {
                c = "Kadın";
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciGetir(textBox2.Text);
        }
    }
}
