namespace Sinif_GeriyeDegerDondurmeyenMetotlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Mesaj msj = new Mesaj();
            msj.metin();
            
            Kisiler kisiler = new Kisiler();
            kisiler.kisiListesi();

            kisiler.kisiListesi2("Arda");


            string ad;
            Console.WriteLine("İsim Giriniz:");
            ad=Console.ReadLine();

            kisiler.kisiListesi2(ad);


            Console.Read();

        }
    }
}
