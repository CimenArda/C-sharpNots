namespace Sinif_GeriyeDegerDondurenMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            İslem islem =new İslem();

            Console.WriteLine("Sonuc:"+islem.topla(4, 6));
            Console.WriteLine("Sonuc:"+islem.topla(4, 17));

            Console.WriteLine("\n \n");
            Console.WriteLine("Cevap:" + islem.kare(5));
            Console.Read();

        }
    }
}
