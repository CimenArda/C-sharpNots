using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapıları
{
    public partial class Bilgi_Yarismasi : Form
    {
        public Bilgi_Yarismasi()
        {
            InitializeComponent();
        }

        private void Bilgi_Yarismasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnSonraki.Enabled = true;

            label2.Text = btnA.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;

            }
        }

        int soruNo = 0, dogru = 0, yanlis = 0;
        private void btnSonraki_Click(object sender, EventArgs e)
        {

            btnA.Enabled = true; 
            btnB.Enabled = true; 
            btnC.Enabled = true; 
            btnD.Enabled = true; 

            btnSonraki.Enabled = false;


            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruNo++;
            lblSoruNo.Text = soruNo.ToString();
            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";

                label1.Text = "1923";

            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden Hangisi Ege Bölgesinde Bulunmaz ?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";

                label1.Text = "Balıkesir";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Kuşlar Hangi Yazarımıza Aittir?";
                btnA.Text = "Sait Faik Abasıyanık";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Reşat Nuri Güntekin";

                label1.Text = "Sait Faik Abasıyanık";

                btnSonraki.Text = "Sonuçlar";
            
            }
            if(soruNo == 4)
            {
                btnA.Enabled=false;
                btnB.Enabled=false;
                btnC.Enabled=false;
                btnD.Enabled=false;
                
                btnSonraki.Enabled=false;

                MessageBox.Show("Doğru Sayısı:" + dogru + " " + "Yanlış:" + yanlis);
            }


        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnSonraki.Enabled = true;


            label2.Text = btnB.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;

            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnSonraki.Enabled = true;



            label2.Text = btnC.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnSonraki.Enabled = true;



            label2.Text = btnD.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;

            }
        }
    }
}
