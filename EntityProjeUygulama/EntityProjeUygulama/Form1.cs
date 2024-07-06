using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db =new DbEntityUrunEntities();
        

        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.Tbl_Kategoriler.ToList();
            dataGridView1.DataSource = kategoriler;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Kategoriler t =new Tbl_Kategoriler();
            t.Ad=txtKategoriAd.Text;
            db.Tbl_Kategoriler.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklenmiştir");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           
            int x  = Convert.ToInt32(txtkategoriid.Text);


            var ktgr = db.Tbl_Kategoriler.Find(x);
            db.Tbl_Kategoriler.Remove(ktgr); 
            db.SaveChanges();
            MessageBox.Show("Kategori Silinmiştir");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(txtkategoriid.Text);
            var ktgr = db.Tbl_Kategoriler.Find(x);

            ktgr.Ad = txtKategoriAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellenmiştir");


        }
    }
}
