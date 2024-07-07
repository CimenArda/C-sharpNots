using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
namespace LogicLayer
{
    public class LogicPersonel
    {

        public static List<EntityPersonel> LlPersonelListesi()
        {
            return DataAccessLayer.DalPersonel.PersonelListele();
        }
        public static int LlPersonelEkle(EntityPersonel p )
        {
          if(p.Ad!="" &&p.Soyad!=""&&p.Maas>3500 &&p.Ad.Length >= 5)
            {
                return DalPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LlPersonelSil(int per )
        {
            if (per >1)
            {
                return DataAccessLayer.DalPersonel.PersonelSil(per);

            }
            else { return false; }

        }

        public static bool LlPersonelGüncelle(EntityPersonel per)
        {
            if (per.Ad.Length>=4 &&per.Ad!="")
            {
                return DataAccessLayer.DalPersonel.PersonelGuncelle(per);

            }
            else { return false; }

        }
    }
}
