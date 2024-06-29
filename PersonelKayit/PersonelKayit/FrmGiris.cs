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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=ArdaCimen\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            SqlCommand komutf1 = new SqlCommand("Select * from Tbl_Yonetici where KullaniciAd=@p1 and Sifre=@p2", connection);
            komutf1.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
            komutf1.Parameters.AddWithValue("@p2", txtsifre.Text);

            SqlDataReader dr = komutf1.ExecuteReader(); 
            if (dr.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            connection.Close();


        }
    }
}
