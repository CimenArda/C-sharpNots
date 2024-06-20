namespace ConstructorMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Ogrenci ogr = new Ogrenci();

            Ogrenci ogr2 = new Ogrenci("Arda-Yeşilay kolu");







            Kimlik kml = new Kimlik();

            kml.AD = "Arda";
            kml.SOYAD = "Cimen";
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CİNSİYET);


            //ilk değeri göndermezsen varsayılanı alır gönderirsen gönderdiğin değeri alır.

            Console.Read();

        }
    }
}
