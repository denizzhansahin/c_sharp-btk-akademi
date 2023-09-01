namespace ConsoleApp {
    class Program{
        static void Main(string[] args){
            System.Console.WriteLine("Merhaba BTK");
            Console.WriteLine("Merhaba BTK 2");

            //Directory.CreateDirectory("temp");

            Ogrenci ogr1 = new Ogrenci();
            ogr1.OgrenciNo = "100";
            ogr1.AdSoyad = "Denizhan ŞAHİN";
            ogr1.Sube = "Universite";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.OgrenciNo = "101";
            ogr2.AdSoyad = "Deniz";
            ogr2.Sube ="Lise";

            Console.WriteLine($"{ogr1.AdSoyad} isimli {ogr1.OgrenciNo} ogrenci şubesi {ogr1.Sube}");
            
            Ogrenci[] ogrenciler = new Ogrenci[2];
            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;

            foreach(var ogr in ogrenciler){
                Console.WriteLine($"{ogr.AdSoyad} ve {ogr.Sube} ve {ogr.OgrenciNo}");
            }

        }
    }

    class Ogrenci{
        public string OgrenciNo {get;set;}
        public string AdSoyad {get;set;}
        public string Sube {get;set;}

    }
}