using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_GeriyeDegerDondurmeyenMetotlar
{
    public class Kisiler
    {
        public void kisiListesi()
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i+".Kisi");
            }
           
        }

        public void kisiListesi2(string ad)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i +"defa Merhaba"+ ad );
            }

        }
    }
}
