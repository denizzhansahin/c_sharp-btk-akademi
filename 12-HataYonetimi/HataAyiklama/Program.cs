using System.Collections.Generic;
namespace ConsoleApp{
    class Program{
        static void Main(string[] args){
            //exception
            //system.formatException - yanlış tip veri
            //system.dividebyzeroexception - 0 bölme hatası
            //system.nullreferenceException - alan ayrımama hatası
            Console.Write("1.Sayi : ");
            int sayi1= Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Sayi : ");
            int sayi2= Convert.ToInt32(Console.ReadLine());

            var sonuc = sayi1 / sayi2;

            /*
            Urun p = null;
            Console.Write(p.UrunAdi);
            */
            
            //exception handling
        }
    }

    class Urun{
        public string UrunAdi {get;set;}
    }
}