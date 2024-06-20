using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMetotlar
{
    public class Ogrenci
    {
        public Ogrenci()
        {
            Console.WriteLine("Ad:Arda");
            Console.WriteLine("SoyAd:Cimen");
            Console.WriteLine("Meslek:Öğretmen");
        }
        public Ogrenci(string bilgi)
        {
            Console.WriteLine(bilgi);
        }

    }
}
