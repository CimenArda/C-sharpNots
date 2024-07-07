using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using EntityLayer;
using DataAccessLayer;
namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> entityPersonels = LogicPersonel.LlPersonelListesi();

            dataGridView1.DataSource = entityPersonels;

            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();

            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text);


            LogicLayer.LogicPersonel.LlPersonelEkle(ent);
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            EntityPersonel entity = new EntityPersonel();
                entity.Id =Convert.ToInt32(txtid.Text);
            LogicPersonel.LlPersonelSil(entity.Id);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            EntityPersonel entity = new EntityPersonel();
            entity.Id = Convert.ToInt32(txtid.Text);

            entity.Ad = txtad.Text;
            entity.Soyad = txtsoyad.Text;
            entity.Sehir = txtsehir.Text;
            entity.Gorev = txtgorev.Text;
            entity.Maas = short.Parse(txtmaas.Text);


            LogicLayer.LogicPersonel.LlPersonelGüncelle(entity);
        }
    }
}
