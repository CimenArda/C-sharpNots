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
namespace PersonelKayit
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=ArdaCimen\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            //grafik 1
            connection.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count(*) from Tbl_Personel Group by Persehir", connection);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read()) 
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            connection.Close();


            //grafik 2 

            connection.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerMeslek,Avg(Permaas) from Tbl_Personel Group by PerMeslek", connection);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while(dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);

            }
            connection.Close();


        }
    }
}
