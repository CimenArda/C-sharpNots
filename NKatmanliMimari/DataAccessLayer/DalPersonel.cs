﻿using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalPersonel
    {
        public static List<EntityPersonel> PersonelListele()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Bilgi", Baglanti.bgl);


            if (komut.Connection.State !=ConnectionState.Open)
            {
                komut.Connection.Open();


            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["Ad"].ToString();
                ent.Soyad = dr["Soyad"].ToString();
                ent.Sehir = dr["Şehir"].ToString();
                ent.Gorev = dr["Gorev"].ToString();
                ent.Maas = short.Parse(dr["Maas"].ToString());

                degerler.Add(ent);
            }
            dr.Close();

            return degerler;
            

        }

        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("Insert into Tbl_Bilgi(Ad,Soyad,Gorev,Şehir,Maas) values (@p1,@p2,@p3,@p4,@p5)",Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();


            }
            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soyad);
            komut2.Parameters.AddWithValue("@p3", p.Gorev);
            komut2.Parameters.AddWithValue("@p4", p.Sehir);
            komut2.Parameters.AddWithValue("@p5", p.Maas);
          
           return  komut2.ExecuteNonQuery();



        }


        public static bool PersonelSil(int p)
        {
            SqlCommand komut2 = new SqlCommand("Delete from Tbl_Bilgi where ID=@p1", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p);

            return komut2.ExecuteNonQuery()> 0;

        }


        public static bool PersonelGuncelle(EntityPersonel ent)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Bilgi set Ad=@p1,Soyad=@p2,Maas=@p3,Şehir=@p4,Gorev=@p5 where ID =@p6",Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();


            }
            komut.Parameters.AddWithValue("@p1", ent.Ad);
            komut.Parameters.AddWithValue("@p2", ent.Soyad);
            komut.Parameters.AddWithValue("@p3", ent.Maas);
            komut.Parameters.AddWithValue("@p4", ent.Sehir);
            komut.Parameters.AddWithValue("@p5", ent.Gorev);
            komut.Parameters.AddWithValue("@p6", ent.Id);

            return komut.ExecuteNonQuery() >0;
        }

    }
}
