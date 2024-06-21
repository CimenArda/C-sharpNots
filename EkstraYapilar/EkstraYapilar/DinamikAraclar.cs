using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraYapilar
{
    public partial class DinamikAraclar : Form
    {
        public DinamikAraclar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new();
            
            Point btnkonum = new Point(20,10);

            btn.Location = btnkonum;
            btn.Name = "Button1";
            btn.Text = "Tıkla";
            btn.BackColor= Color.ForestGreen;
            btn.Height = 50;
            btn.Width = 230;


            Label lbl =new Label();

            Point lblkonum =new Point(250,25);

            lbl.Location = lblkonum;
            lbl.Name = "Label1";
            lbl.Text = "Merhaba";
            lbl.BackColor = Color.Yellow;




            for(int i =1;i <5;i++)
            {
                TextBox txt = new TextBox();

                Point txtKonum = new Point(340,i*30);
                txt.Location = txtKonum;
                txt.Name = "textbox:" + i;
                txt.Text =i.ToString();
                this.Controls.Add(txt);
            }



            this.Controls.Add(lbl);

            this.Controls.Add(btn);

        }
    }
}
