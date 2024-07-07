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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db =new DbEntityUrunEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {

            toplamKategori.Text =db.Tbl_Kategoriler.Count().ToString();
            toplamUrun.Text =db.Tbl_Urunler.Count().ToString();

            AktifMüsteri.Text =db.Tbl_Musteriler.Count(x=>x.MusteriDurum ==true).ToString();

            PasifMüsteri.Text =db.Tbl_Musteriler.Count(x=>x.MusteriDurum == false).ToString();

            ToplamStok.Text =db.Tbl_Urunler.Sum(x=>x.Stok).ToString();


            Kasatutarı.Text = db.Tbl_Satislar.Sum(x => x.Fiyat).ToString() +" TL";

            EnyüksekFiyatliUrun.Text =(from x in db.Tbl_Urunler orderby x.FİYAT descending select x.UrunAd).FirstOrDefault();


            EndusukFiyatliUrun.Text =(from x in db.Tbl_Urunler orderby x.FİYAT ascending select x.UrunAd).FirstOrDefault();

           BeyazEsya.Text=  db.Tbl_Urunler.Count(x=>x.Kategori ==1).ToString();

            toplamBuzdolabı.Text =db.Tbl_Urunler.Count(x=>x.UrunAd =="Buzdolabı").ToString();

            SehirSayısı.Text = (from x in db.Tbl_Musteriler select x.MusteriSehir).Distinct().Count().ToString();

            EnfazlaÜrünlüMarka.Text = db.MarkaGetir().FirstOrDefault();
            
        }

        private void EnfazlaÜrünlüMarka_Click(object sender, EventArgs e)
        {

        }
    }
}
