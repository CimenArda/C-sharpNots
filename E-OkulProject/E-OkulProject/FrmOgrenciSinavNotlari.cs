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
    public partial class FrmOgrenciSinavNotlari : Form
    {
        public FrmOgrenciSinavNotlari()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ArdaCimen\\SQLEXPRESS;Initial Catalog=EOkulProject;Integrated Security=True;");
        public string numara;
        private void FrmOgrenciSinavNotlari_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DersAd,Sınav1,Sınav2,Sınav3,Proje,Ortalama,Durum from Tbl_Notlar\r\nInner join Tbl_Dersler \r\non\r\nTbl_Notlar.DersId =Tbl_Dersler.DersId where OgrId=@p1", baglanti);

            komut.Parameters.AddWithValue("@p1", numara);
            //this.Text = numara.ToString();

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }
    }
}
