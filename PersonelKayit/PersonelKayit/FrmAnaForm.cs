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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=ArdaCimen\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
        }


        void Temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtmeslek.Text = "";

            mskmaas.Text = "";
            cmbsehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtad.Focus();
        }



        private void btnkaydet_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("Insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values(@p1,@p2,@p3,@p4,@p5,@p6)", connection);

            command.Parameters.AddWithValue("@p1", txtad.Text);
            command.Parameters.AddWithValue("@p2", txtsoyad.Text);
            command.Parameters.AddWithValue("@p3", cmbsehir.Text);
            command.Parameters.AddWithValue("@p4", mskmaas.Text);
            command.Parameters.AddWithValue("@p5", txtmeslek.Text);
            command.Parameters.AddWithValue("@p6", label8.Text);

            command.ExecuteNonQuery();


            connection.Close();
            MessageBox.Show("Personel Eklendi");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilendeger].Cells[6].Value.ToString();
            cmbsehir.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            label8.Text = dataGridView1.Rows[secilendeger].Cells[5].Value.ToString();

            mskmaas.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();


        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand commanddelete= new SqlCommand("Delete from Tbl_Personel Where Perid=@k1",connection);
            commanddelete.Parameters.AddWithValue("@k1", txtid.Text);

            commanddelete.ExecuteNonQuery();
        
            connection.Close();
            MessageBox.Show("Komut Silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand commandUpdate = new SqlCommand("Update Tbl_Personel Set PerAd=@a1 ,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", connection);

            commandUpdate.Parameters.AddWithValue("@a1", txtad.Text);
            commandUpdate.Parameters.AddWithValue("@a2", txtsoyad.Text);
            commandUpdate.Parameters.AddWithValue("@a3", cmbsehir.Text);
            commandUpdate.Parameters.AddWithValue("@a4", mskmaas.Text);
            commandUpdate.Parameters.AddWithValue("@a5", label8.Text);
            commandUpdate.Parameters.AddWithValue("@a6", txtmeslek.Text);

            commandUpdate.Parameters.AddWithValue("@a7",txtid.Text);

            commandUpdate.ExecuteNonQuery();




            connection.Close();

            MessageBox.Show("Personel Bilgisi Güncellendi");
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik();
            fr.Show();
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            FrmGrafik fr2 = new FrmGrafik();
            fr2.Show();

        }
    }
}