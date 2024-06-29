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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=ArdaCimen\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            connection.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) from Tbl_Personel",connection);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                lblToplamPersonel.Text = dr1[0].ToString();
            }


            connection.Close();

            //Evli Personel Sayısı

            connection.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) from Tbl_Personel where PerDurum =1", connection);

            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                lblEvliPersonel.Text = dr2[0].ToString();
            }


            connection.Close();

            //Bekar Personel Sayısı
            connection.Open();

            SqlCommand komut3 = new SqlCommand("Select Count(*) from Tbl_Personel where PerDurum =0", connection);

            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                lblBekarPersonel.Text = dr3[0].ToString();
            }


            connection.Close();



            //Farklı Sehir Sayısı

             connection.Open();

            SqlCommand komut4 = new SqlCommand("Select Count(Distinct(PerSehir)) from Tbl_Personel", connection);

            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                lblFarkliSehir.Text = dr4[0].ToString();
            }


            connection.Close();




            //Personel Toplam Maas


             connection.Open();

            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) from Tbl_Personel", connection);

            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                lblToplamMaas.Text = dr5[0].ToString();
            }


            connection.Close();


            //Personel Ortalama Maas


            connection.Open();

            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) from Tbl_Personel", connection);

            SqlDataReader dr6 = komut6.ExecuteReader();

            while (dr6.Read())
            {
                lblOrtalamaMaas.Text = dr6[0].ToString();
            }


            connection.Close();

        }









    }
}
