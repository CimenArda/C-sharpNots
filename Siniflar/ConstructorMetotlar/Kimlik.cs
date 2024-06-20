using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMetotlar
{
    public class Kimlik
    {
        string ad;
        string Soyad;
        string Memleket;

        int yas;
        char cinsiyet;


       public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }

        public string SOYAD
        {
            get { return Soyad; }
            set { Soyad = value.ToUpper(); }
        }

        public string MEMLEKET
        {
            get { return Memleket; }
            set { Memleket = value.ToUpper(); }
        }


        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }
        public char CİNSİYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public Kimlik()
        {
            ad = "";
            Soyad = "";
            yas = 18;
            cinsiyet = 'E';
            Memleket = "Ankara";

        }
    }
}