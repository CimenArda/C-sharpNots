using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public class Araba :ArabaDetay
    {
        public string Renk;
        public int hiz;
        public double motor;
        public char Durum;
        public int Fiyat;

        private int yil;
        private string Marka;

        public int YIL
        {
            get { return yil; }//geriye döndürelecek değer
            set { yil = Math.Abs(value); } //değer girişi
        }

        public string Markasi
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); }
        }
    }
}
