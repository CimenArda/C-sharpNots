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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategoriler
                               select new { x.ID, x.Ad }
                               ).ToList();

            cmbKategori.ValueMember = "ID";
            cmbKategori.DisplayMember = "Ad";
            cmbKategori.DataSource = kategoriler;


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urunler
                                        select new
                                        {
                                            x.UrunID,
                                            x.UrunAd,
                                            x.Marka,
                                            x.Stok,
                                            x.FİYAT,
                                            x.Tbl_Kategoriler.Ad,
                                            x.Durum
                                        }).ToList();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Urunler t = new Tbl_Urunler();
            t.UrunAd = txtUrun.Text;
            t.Marka = txtMarka.Text;
            t.Stok = short.Parse(txtStok.Text);
            t.FİYAT = Convert.ToDecimal(txtFiyat.Text);
            t.Kategori = int.Parse(cmbKategori.Text);
            t.Durum = true;
            db.Tbl_Urunler.Add(t);
            db.SaveChanges();
            MessageBox.Show("Urun Eklenmiştir");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);


            var ktgr = db.Tbl_Urunler.Find(x);
            db.Tbl_Urunler.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Ürünler Silinmiştir");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var ktgr = db.Tbl_Urunler.Find(x);

            ktgr.UrunAd = txtUrun.Text;
            ktgr.Marka = txtMarka.Text;
            ktgr.Stok = short.Parse(txtStok.Text);
            ktgr.FİYAT = decimal.Parse(txtFiyat.Text);
            ktgr.Kategori = int.Parse(cmbKategori.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellenmiştir");
        }
    }
}
